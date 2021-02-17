using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KH095.Models;
using KH095.Data;
using Microsoft.EntityFrameworkCore;

namespace KH095.Controllers
{
    [Route("/product")]
    public class ProductPageController : Controller
    {
        private readonly ILogger<ProductPageController> _logger;
        private ApplicationDbContext db;

        public ProductPageController(ILogger<ProductPageController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        [HttpGet("search")]
        public IActionResult Index(string category = null, string q = null, int page = 1, int pageSize = 20)
        {
            var query = db.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
               query = query.Where(item => item.ProductTypes.Name == category);
            }

            if (!string.IsNullOrWhiteSpace(q))
            {
                q = $"%{q}%"; 
                query =  query.Where(item => EF.Functions.ILike(item.Title,q));
            }

            var Products = query
                             .OrderByDescending(item => item.CreatedTime)
                             .Take(pageSize)
                             .Skip(page)
                             .ToList();
            

            return View("/Views/Product/productCategory.cshtml", Products);
        }
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            var found = db.Products.Where(item => item.Id == id)
                                    .Select(item => new Product
                                    {
                                        Id = item.Id,
                                        Title = item.Title,
                                        TypeId = item.TypeId,
                                        Price = item.Price,
                                        Image = item.Image,
                                        Images = item.Images,
                                        Colors = item.Colors,
                                        Sizes = item.Sizes,
                                        Description = item.Description,
                                        Content = item.Content,
                                        Quantity = item.Quantity,
                                        Rate = item.Rate,
                                        CreatedTime = item.CreatedTime,
                                        UpdatedTime = item.UpdatedTime,
                                        ProductTypes = item.ProductTypes,
                                        ProductTags = item.ProductTags.Select(lt => new ProductTag
                                        {
                                            Tag = lt.Tag
                                        }).ToList(),
                                    })
                                    .FirstOrDefault();

            ViewBag.productPopular = db.Products
                                       .Where(item => item.TypeId == found.TypeId && item.Id != found.Id)
                                       .OrderBy(item => item.Id)
                                       .Skip(0)
                                       .Take(4)
                                       .ToList();

            return View("/Views/Product/productDetail.cshtml", found);
        }
    }
}

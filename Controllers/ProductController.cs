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
using KH095.Extension;
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
        public IActionResult Index(int? categoryId = null, string q = null, int page = 1, int pageSize = 20)
        {

            var Categories = HttpContext.Session.Get<List<ProductType>>("categories");

            if (Categories == null)
            {
                var productTypes = db.ProductTypes
                                     .Where(item => item.ProductTypeChildrens.Any())
                                     .Select(item => new ProductType
                                     {
                                         Id = item.Id,
                                         Name = item.Name,
                                         Description = item.Description,
                                         ProductTypeChildrens = item.ProductTypeChildrens
                                     })
                                     .ToList();
                HttpContext.Session.Set<List<ProductType>>("categories", productTypes);
                Categories = productTypes;
            }
            var query = db.Products.AsQueryable();

            if (categoryId != null)
            {
                query = query.Where(item => item.ProductTypes.Id == categoryId);
            }

            if (!string.IsNullOrWhiteSpace(q))
            {
                q = $"%{q}%";
                query = query.Where(item => EF.Functions.ILike(item.Title, q));
            }


            var Products = query
                             .OrderByDescending(item => item.CreatedTime)
                             .Take(pageSize)
                             .Skip(page)
                             .ToList();

            ViewBag.CurentPage = page;
            var totalProduct = query.Count();
            ViewBag.TotalPage = totalProduct % pageSize == 0 ? totalProduct / pageSize : totalProduct / pageSize + 1;
            ViewBag.Query = query;
            ViewBag.CategoryName = db.ProductTypes.Where(item => item.Id == categoryId).Select(item => item.Name).FirstOrDefault();
            return View("/Views/Product/productCategory.cshtml", Products);
        }
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {

            var Categories = HttpContext.Session.Get<List<ProductType>>("categories");

            if (Categories == null)
            {
                var productTypes = db.ProductTypes
                                     .Where(item => item.ProductTypeChildrens.Any())
                                     .Select(item => new ProductType
                                     {
                                         Id = item.Id,
                                         Name = item.Name,
                                         Description = item.Description,
                                         ProductTypeChildrens = item.ProductTypeChildrens
                                     })
                                     .ToList();
                HttpContext.Session.Set<List<ProductType>>("categories", productTypes);
                Categories = productTypes;
            }
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

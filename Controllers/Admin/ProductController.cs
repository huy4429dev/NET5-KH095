using System;
using System.Linq;
using System.Collections.Generic;
using KH095.Data;
using KH095.Models;
using Microsoft.AspNetCore.Mvc;
using KH095.Services;
using Microsoft.EntityFrameworkCore;

namespace KH095.Controllers
{
    [Route("/admin/product")]
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext db;

        public ProductController(ApplicationDbContext db)
        {

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 25)
        {

            var Products = db.Products
                          .OrderByDescending(item => item.Id)
                          .Skip((page - 1) * pageSize)
                          .Take(pageSize)
                          .ToList();

            ViewData["ProductTypes"] = db.ProductTypes.ToList();
            ViewBag.TotalPage = db.Products.Count() / pageSize == 0 ? db.Products.Count() / pageSize : db.Products.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/product/Index.cshtml", Products);
        }

        [HttpGet("search")]

        public IActionResult Search(string query, int page = 1, int pageSize = 25)
        {

            query = "%" + query + "%";

            var Products = db.Products
                                  .Where(item => EF.Functions.ILike(item.Title, query)
                                                 || EF.Functions.ILike(item.Description, query)
                                         )
                                   .Select(item => new Product
                                   {
                                       Title = item.Title,
                                       CreatedTime = item.CreatedTime,
                                       UpdatedTime = item.UpdatedTime,
                                       Description = item.Description,
                                       Id = item.Id,
                                       Image = item.Image,
                                       ProductTypes = item.ProductTypes,
                                   })
                                  .OrderByDescending(item => item.Id)
                                  .Skip((page - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToList();

            ViewData["ProductTypes"] = db.ProductTypes.ToList();
            ViewBag.TotalPage = db.Products.Count() / pageSize == 0 ? db.Products.Count() / pageSize : db.Products.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/product/Index.cshtml", Products);
        }


        //=== add category

        [HttpPost]
        public IActionResult Create([FromForm] Product model)
        {
            // if (ModelState.IsValid)
            // {

            db.Products.Add(model);
            model.Rate = 5;
            model.CreatedTime = DateTime.Now;
            model.UpdatedTime = DateTime.Now;
            db.SaveChanges();

            // alert success to view
            TempData["message"] = "Thêm mới sản phẩm thành công";
            // }

            return RedirectToAction("Index");

        }

        //=== edit category

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] Product model)
        {

            if (ModelState.IsValid)
            {
                var found = db.Products.Find(id);

                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Cateogry", "Category not found");
                }

                // add category

                // found.Name = model.Name;
                // found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Cập nhật sản phẩm thành công";
            }

            return RedirectToAction("Index");

        }

        //=== delete category

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Products.Find(id);

            // check category found

            if (found == null)
            {
                ModelState.AddModelError("Found Cateogry", "Category not found");
            }

            db.Products.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Xóa sản phẩm thành công";

            return RedirectToAction("Index");
        }



    }
}
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
    [Route("/admin/product/producttype")]
    public class ProductCategoryController : Controller
    {

        private readonly ApplicationDbContext db;

        public ProductCategoryController(ApplicationDbContext db)
        {

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var Categories = db.ProductTypes.OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/product/ProductType.cshtml", Categories);
        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {
            
            query = "%" + query + "%";
            
            var Categories = db.ProductTypes
                               .Where(item => EF.Functions.ILike(item.Name, query)
                                              || EF.Functions.ILike(item.Description, query)
                                      )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/product/ProductType.cshtml", Categories);
        }


        //=== add category

        [HttpPost]
        public IActionResult Create([FromForm] ProductType model)
        {

            if (ModelState.IsValid)
            {
                var found = db.ProductTypes.Any(item => item.Name == model.Name);

                // check category found

                if (found)
                {
                    ModelState.AddModelError("Found Product type", "Product type name is found");
                }

                // add category

                db.ProductTypes.Add(model);
                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Thêm loại sản phẩm thành công";
            }

            return RedirectToAction("Index");

        }

        //=== edit category

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] ProductType model)
        {

            if (ModelState.IsValid)
            {
                var found = db.ProductTypes.Find(id);

                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Product type", "Product type not found");
                }

                // add category

                found.Name = model.Name;
                found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Sửa sản phẩm thành công";
            }

            return RedirectToAction("Index");

        }

        //=== delete category

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.ProductTypes.Find(id);
            if (found == null)
            {
                ModelState.AddModelError("Found Product type", "Product type not found");
            }

            db.ProductTypes.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Xóa sản phẩm thành công";

            return RedirectToAction("Index");
        }



    }
}
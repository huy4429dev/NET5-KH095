using System;
using System.Linq;
using System.Collections.Generic;
using KH095.Data;
using KH095.Models;
using Microsoft.AspNetCore.Mvc;
using KH095.Services;
using Microsoft.EntityFrameworkCore;

namespace KH095.Admin.Controllers
{
    [Route("/admin/customer")]
    public class CustomerController : Controller
    {

        private readonly ApplicationDbContext db;

        public CustomerController(ApplicationDbContext db)
        {

            this.db = db;
        }


        public IActionResult Index(int page = 1, int pageSize = 25)
        {

            var query = db.Users.AsQueryable();
            var Customers = query
                              .Where(item => item.UserRoles.Any(r => r.Role.Name.ToLower() != "admin"))
                              .OrderBy(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();

            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("/Views/Admin/Customer/Index.cshtml", Customers);
        }

        [HttpGet("search")]

        public IActionResult Search(string query, DateTime? fillDate, int page = 1, int pageSize = 25)
        {
            var sql = db.Users
                        .Where(item => item.UserRoles.Any(r => r.Role.Name.ToLower() != "admin"))
                        .AsNoTracking();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Username, query)
                                        || EF.Functions.ILike(item.Address, query)
                                        || EF.Functions.ILike(item.FullName, query)
                                        || EF.Functions.ILike(item.Phone, query)
                               );
            }

            if (fillDate.HasValue)
            {
                sql = sql.Where(item => item.CreatTime == fillDate);
            }

            var Customers = sql.OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/Customer/Index.cshtml", Customers);
        }


        [HttpPost()]
        public IActionResult Create([FromForm] User model)
        {
            SkipModelValidate("ConfirmPassword");

            if (ModelState.IsValid)
            {

                var found = db.Users.Any(item => item.Username == model.Username || item.Email == model.Email);

                if (found)
                {
                    ModelState.AddModelError("Found Customer", "Khách hàng đã tồn tại");
                }
                else
                {
                    model.CreatTime = DateTime.Now;
                    model.Status = true;
                    model.UserRoles = new List<UserRole> {
                        new UserRole {
                            RoleId = 2
                        }
                    };
                    db.Users.Add(model);
                    db.SaveChanges();
                    TempData["message"] = "Thêm mới khách hàng thành công";
                }

            }
            else
            {
                TempData["Error"] = ModelState.Select(x => x.Value.Errors)
                                  .Where(y => y.Count > 0)
                                  .First()
                                  .Select(m => m.ErrorMessage)
                                  .First();

            }

            return RedirectToAction("Index");

        }

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] User model)
        {
            SkipModelValidate("ConfirmPassword");
            SkipModelValidate("Username");
            SkipModelValidate("Password");
            if (ModelState.IsValid)
            {
                var found = db.Users.Find(id);
                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Customer", "Không tồn tại khách hàng");
                }

                found.FullName = model.FullName;
                found.Address = model.Address;
                found.Phone = model.Phone;
                found.BirthDate = model.BirthDate;

                // add category
                found.Status = true;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Cập nhật khách hàng thành công";
            }
            return RedirectToAction("Index");

        }

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Users.Find(id);

            // check category found

            if (found == null)
            {
                ModelState.AddModelError("Found Customer", "Customer not found");
            }

            db.Users.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Xóa khách hàng thành công";

            return RedirectToAction("Index");
        }


        private void SkipModelValidate(string keyword)
        {
            if (ModelState != null)
            {
                foreach (var item in ModelState)
                {
                    if (item.Key.Contains(keyword))
                    {
                        ModelState.Remove(item.Key);
                    }
                }
            }
        }
    }
}
using System.Linq;
using KH095.Data;
using KH095.Models;
using Microsoft.AspNetCore.Mvc;
using KH095.Services;
using KH095.ViewModels;
using KH095.Extension;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace KH095.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext db;

        public AccountController(ApplicationDbContext db)
        {

            // create a function

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var user = HttpContext.Session.Get<User>("customer");

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("/Views/Account/Index.cshtml");
        }


        [HttpPost("customer/login")]
        public IActionResult Login([FromForm] LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                string UserName = model.UserName;
                string Password = AesOperation.EncryptString("mot cai key khong thang nao biet", model.Password);
                // string Password = model.Password;

                var found = db.Users
                            .FirstOrDefault(item =>
                                                          item.Username == UserName &&
                                                          item.Password == Password
                                                    )
                            ;

                if (found != null)
                {
                    HttpContext.Session.Set<User>("customer", new User
                    {
                        Username = found.Username,
                        Id = found.Id,
                        UserRoles = found.UserRoles,
                        Email = found.Email,
                        FullName = found.FullName,
                        Address = found.Address,
                        Phone = found.Phone

                    });

                    return Redirect(Request.Headers["Referer"].ToString());
                }

                TempData["Error"] = "Sai tên đăng nhập hoặc mật khẩu";


            }
            else
            {
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
            }

            return View("/Views/Account/Index.cshtml");

        }


        [HttpGet("customer/logout")]
        public IActionResult LogOut()
        {

            HttpContext.Session.Clear();
            return Redirect(Request.Headers["Referer"].ToString());
        }


        [HttpPost("customer/register")]
        public IActionResult RegisterCustomer([FromForm] User model)
        {
            string key = "mot cai key khong thang nao biet";
            var RoleCustomer = db.Roles.FirstOrDefault(r => r.Name == "Customer");
            if (db.Users.Any(item => item.Username == model.Username))
            {
                ModelState.AddModelError(string.Empty, "Tên tài khoản đã được sử dụng");
            }

            if (db.Users.Any(item => item.Email == model.Email))
            {
                ModelState.AddModelError(string.Empty, "Địa chỉ email đã được sử dụng");
            }

            if (ModelState.IsValid)
            {
                var customer = new User
                {
                    Username = model.Username,
                    Email = model.Email,
                    FullName = model.FullName,
                    Status = true,
                    Password = AesOperation.EncryptString(key, model.Password),
                    CreatTime = DateTime.Now,
                    UserRoles = new List<UserRole> {
                        new UserRole {
                            Role = RoleCustomer
                        }
                    },
                };

                db.Users.Add(customer);
                db.SaveChanges();

                TempData["Message"] = "Tạo tài khoản thành công";
            }
            else
            {
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet("customer/profile")]
        public IActionResult Profile()
        {

            var user = HttpContext.Session.Get<User>("customer");

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("/Views/Account/Profile.cshtml");
        }

        [HttpPost("customer/update")]
        public IActionResult EditProfle([FromForm] User model)
        {


            var user = HttpContext.Session.Get<User>("customer");
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            string key = "mot cai key khong thang nao biet";
            SkipModelValidate("Password");
            SkipModelValidate("Username");
            if (ModelState.IsValid)
            {
                var customer = db.Users.Find(user.Id);
                customer.Email = model.Email;
                customer.FullName = model.FullName;
                customer.Address = model.Address;
                customer.Phone = model.Phone;
                customer.Address = model.Address;
                customer.Email = model.Email;
                HttpContext.Session.Set<User>("customer", new User
                {
                    Username = user.Username,
                    Id = user.Id,
                    UserRoles = user.UserRoles,
                    Email = customer.Email,
                    FullName = customer.FullName,
                    Address = customer.Address,
                    Phone = customer.Phone

                });
                if (model.Password != null)
                {
                    customer.Password = AesOperation.EncryptString(key, model.Password);
                }
                db.SaveChanges();
                TempData["Message"] = "Cập nhật tài khoản thành công";
            }
            else
            {
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
            }

            return Redirect(Request.Headers["Referer"].ToString());
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
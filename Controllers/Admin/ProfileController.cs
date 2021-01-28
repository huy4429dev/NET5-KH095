using System;
using System.Linq;
using System.Collections.Generic;
using KH095.Data;
using KH095.Models;
using Microsoft.AspNetCore.Mvc;
using KH095.Services;
using KH095.ViewModels;
using KH095.Extension;
using Microsoft.AspNetCore.Http;

namespace KH095.Admin.ontrollers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProfileController(ApplicationDbContext db)
        {

            // create a function

            this.db = db;
        }


        [HttpGet("admin/profile")]
        public IActionResult Index()
        {
            var user = HttpContext.Session.Get<User>("user"); 

            ViewBag.Role  = db.UserRoles
                              .Where(r => r.UserId == user.Id)
                              .Select(item => item.Role.Name)
                              .FirstOrDefault();

            if (user == null)
            {
                return RedirectToAction("Index", "DashBoard");
            }
            

            return View("/Views/Admin/Profile/Index.cshtml");

        }


        [HttpPost("admin/profile")]
        public IActionResult Login([FromForm] LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                string UserName = model.UserName;
                string Password = AesOperation.EncryptString("mot cai key khong thang nao biet", model.Password);
                // string Password = model.Password;

                var found = db.Users.FirstOrDefault(item =>
                                                          item.Username == UserName &&
                                                          item.Password == Password
                                                    );

                if (found != null)
                {
                    HttpContext.Session.Set<User>("user", new User
                    {
                        Username = found.Username,
                        Id = found.Id,
                        UserRoles = found.UserRoles,
                    });

                    return RedirectToAction("Index", "DashBoard");
                }

                // Check user name and password 
                ModelState.AddModelError(string.Empty, "Username or Password incorrect");

            }

            return View("/Views/Admin/Login/Index.cshtml");

        }

    }
}
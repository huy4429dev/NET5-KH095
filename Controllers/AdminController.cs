using System;
using System.Linq;
using System.Collections.Generic;
using KH095.Data;
using KH095.Models;
using Microsoft.AspNetCore.Mvc;
using KH095.Services;


namespace KH095.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext db;

        public AdminController(ApplicationDbContext db)
        {

            this.db = db;  // create object dbcontext to manipulation db  
        }


        [HttpGet("admin/make-admin")]
        public IActionResult CreateAdmin()
        {

            string key = "mot cai key khong thang nao biet";

            var roleAdmin = new Role
            {
                Name = "Admin"
            };

            db.Roles.Add(roleAdmin);

            var roleCustomer = new Role
            {
                Name = "Customer"
            };

            db.Roles.Add(roleCustomer);

            db.SaveChanges(); 


            var admin = new User
            {
                Username = "admin",
                Email = "admin@gmail.com",
                Status = true,
                FullName = "Admin",
                Password = AesOperation.EncryptString(key,"123456"),
                CreatTime = DateTime.Now,
                UserRoles = new List<UserRole> {
                    new UserRole {
                        Role = roleAdmin
                    }
                },
            };

            db.Users.Add(admin);
            db.SaveChanges();

            return Ok("admin created !");
        }
        
   
   
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using KH095.Data;
using KH095.Models;
using Microsoft.AspNetCore.Mvc;
using KH095.Services;
using KH095.Extension;
using Microsoft.EntityFrameworkCore;
using KH095.ViewModels;

namespace KH095.Controllers
{
    public class DashBoardController : Controller
    {

        private readonly ApplicationDbContext db;

        public DashBoardController(ApplicationDbContext db)
        {

            // create a function

            this.db = db;  // create object dbcontext to manipulation db 
        }

        [HttpGet("admin/dashboard")]
        public IActionResult Index()
        {

            // check login 

            var user = HttpContext.Session.Get<User>("user"); // lấy thông tin user dang đăng nhập 

            if (user == null)
            {
                return RedirectToAction("Index", "Login"); // chưa đăng nhập về trang đăng nhập
            }
            ViewData["User"] = new User
            {
                Username = user.Username
            };

            // thong ke trong thang hien tai 

            const int DATE_GAN_TRA = 4;

            var Now = DateTime.Now;
            var PerMonth = Now.Month;
            var PerYear = Now.Year;
            var Date = new DateTime(PerYear, PerMonth, 1);
            var ADD_NOW_DATE_GAN_TRA = Now.AddDays(DATE_GAN_TRA);

            var FirstDayOfWeek = Now.StartOfWeek(DayOfWeek.Monday);
            var LastDayOfWeek = Now.StartOfWeek(DayOfWeek.Sunday);

            //  COUNT CURRENT MONTH 

            ViewBag.TotalNewCustomer = db.Users
                                        .Where(u => u.CreatTime > Date &&
                                                    u.UserRoles.Any(r => r.Role.Name == "Customer")
                                              )
                                        .Count();

            ViewBag.TotalProduct_Muon = db.Orders
                                       .Where(o => o.CreatedTime > Date && o.Status != OrderStatus.Dispose && o.Status != OrderStatus.Success)
                                       .Sum(o => o.OrderDetails.Sum(d => d.Quantity));


            ViewBag.TotalProduct_Phai_Tra = db.Orders
                                       .Where(o => o.CreatedTime > Date
                                                 && o.TimeEnd < ADD_NOW_DATE_GAN_TRA
                                                 && o.Status == OrderStatus.NoProcess 
                                                 )
                                       .Count();

            ViewBag.TotalProduct_Qua_Han = db.Orders
                                       .Where(o => o.CreatedTime > Date
                                                 && o.TimeEnd < Now
                                                 && o.Status == OrderStatus.Dispose 
                                                 )
                                       .Count();

            // SO LIEU BIEU DO 

            var TotalNewCustomerPerWeek = db.Users
                                        .Where(u => u.CreatTime > FirstDayOfWeek &&
                                                    u.UserRoles.Any(r => r.Role.Name == "Customer")
                                              )
                                        .GroupBy(u => u.CreatTime.Date)
                                        .Select(g => new
                                        {
                                            g.Key,
                                            Count = g.Count()
                                        })
                                        .ToList();


            var TotalProduct_MuonPerWeek = db.Orders
                                    .Where(o => o.CreatedTime > FirstDayOfWeek)
                                    .Select(o => new
                                    {
                                        OrderId = o.Id,
                                        Quantity = o.OrderDetails.Sum(d => d.Quantity),
                                        CreatedTime = o.CreatedTime

                                    })
                                    .GroupBy(o => o.CreatedTime.Date)
                                    .Select(g2 => new
                                    {
                                        g2.Key,
                                        Quantity = g2.Sum(g22 => g22.Quantity)
                                    })
                                    .ToList();

            var TotalProduct_Phai_Tra_PerMonth = db.Orders
                                    .Where(o => o.CreatedTime > FirstDayOfWeek
                                                && o.TimeEnd < ADD_NOW_DATE_GAN_TRA
                                                && o.Status == OrderStatus.Borrowed 
                                                )
                                     .Select(o => new
                                     {
                                         OrderId = o.Id,
                                         Quantity = o.OrderDetails.Sum(d => d.Quantity),
                                         CreatedTime = o.CreatedTime

                                     })
                                    .GroupBy(o => o.CreatedTime.Date)
                                    .Select(g2 => new
                                    {
                                        g2.Key,
                                        Quantity = g2.Sum(g22 => g22.Quantity)
                                    })
                                    .ToList();

            var TotalProduct_Qua_Han_PerMoth = db.Orders
                                       .Where(o => o.CreatedTime > FirstDayOfWeek
                                                 && o.TimeEnd < Now
                                                 && o.Status == OrderStatus.Borrowed 
                                                 )
                                        .Select(o => new
                                        {
                                            OrderId = o.Id,
                                            Quantity = o.OrderDetails.Sum(d => d.Quantity),
                                            CreatedTime = o.CreatedTime

                                        })
                                        .GroupBy(o => o.CreatedTime.Date)
                                        .Select(g2 => new
                                        {
                                            g2.Key,
                                            Quantity = g2.Sum(g22 => g22.Quantity)
                                        })
                                        .ToList();

            ViewBag.ListProductOrders = db.OrderDetails.Select(d => new
            {

                Name = d.Product.Title,
                ProductId = d.Product.Id,
                Quantity = d.Quantity
            })
            .GroupBy(b => b.ProductId)
            .Select(g => new
            {
                ProductId = g.Key,
                Count = g.Sum(g2 => g2.Quantity)
            })
            .Join(db.Products,
                                            o1 => o1.ProductId,
                                            o2 => o2.Id,
                                            (o1, o2) => new ListProductDashBoard
                                            {
                                                ProductId = o1.ProductId,
                                                CountDiscount = o1.Count,
                                                Title = o2.Title, 
                                                Quantity = o2.Quantity 
                                            }
             )
            .ToList();


            ViewBag.Chart_PerMonth = new
            {
                TotalNewCustomerPerWeek,
                TotalProduct_Qua_Han_PerMoth,
                TotalProduct_Phai_Tra_PerMonth,
                TotalProduct_MuonPerWeek,
                FirstDayOfWeek

            };

            // SO LIEU BANG 

            return View("/Views/Admin/Dashboard/Index.cshtml");

        }
     
    }
}
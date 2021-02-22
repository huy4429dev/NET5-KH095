using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KH095.Models;
using KH095.Data;

namespace KH095.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationDbContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            ViewBag.ProductHots = db.Products.OrderBy(item => item.CountOrder).Skip(0).Take(8).ToList();
            ViewBag.ProductNews = db.Products.OrderBy(item => item.CreatedTime).Skip(0).Take(8).ToList();
            return View();
        }

    }
}

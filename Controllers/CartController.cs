using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KH095.Models;
using KH095.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace KH095.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private ApplicationDbContext db;

        public CartController(ILogger<CartController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }


        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";

        // Lấy cart từ Session (danh sách CartItem)
        List<CartItem> GetCartItems()
        {

            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        [HttpGet("addcart")]
        public IActionResult AddToCart(int id)
        {
            var product = db.Products
                .Where(p => p.Id == id)
                .FirstOrDefault();
            if (product == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == id);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = 1, product = product });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }

        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }

        /// xóa item trong cart
        [Route("/removecart/{id:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int id)
        {

            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == id);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }
        /// Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromBody] CartItemUpdate model)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == model.productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity = model.quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }

        public class CartItemUpdate
        {
            public int productid { get; set; }
            public int quantity { get; set; }
        }


        [Route("/payment")]
        public IActionResult Payment()
        {

            // Xử lý khi đặt hàng
            return View("/Views/Payment/payment.cshtml",GetCartItems());
        }

        [HttpPost("checkout")]
        public IActionResult CheckOut([FromForm] Order model)
        {
            SkipModelValidate("Username");
            SkipModelValidate("Password");
            SkipModelValidate("Email");
            
            if(ModelState.IsValid){
                var data = HttpContext.Request.Form; 
                var Username = model.Email.Substring(0,model.Email.IndexOf("@"));
                var found = db.Users.FirstOrDefault(item => item.Username == Username || item.Email == model.Email);

                if (found != null)
                {
                    ModelState.AddModelError("Found Customer", "Khách hàng đã tồn tại");
                }

                else
                {
                    found = new User();
                    found.Username = Username;
                    found.FullName = model.FullName;
                    found.Phone = model.Phone;
                    found.Password = model.Email;
                    found.Address = model.Address;
                    found.Email = model.Email;
                    found.CreatTime = DateTime.Now;
                    found.Status = true;
                    found.UserRoles = new List<UserRole> {
                        new UserRole {
                            RoleId = 2
                        }
                    };
                    db.Users.Add(found);
                    db.SaveChanges();
                }

                // add customer 

                // add order
                var now = DateTime.Now;
                var cart = GetCartItems();
                var order = new Order {
                    Amount = cart.Sum(item => item.quantity * item.product.Price),
                    Email = model.Email,
                    FullName = model.FullName,
                    Address = model.Address,
                    Phone = model.Phone,
                    Note = model.Note,
                    UserId = found.Id,
                    Status = OrderStatus.NoProcess,
                    OrderDetails = cart.Select(c => new OrderDetail{
                        ProductId = c.product.Id,
                        Quantity = c.quantity,
                        CreatedTime = now,
                        UpdatedTime = now
                    }).ToList()
                };

                db.Orders.Add(order);
                db.SaveChanges();
            }

            ClearCart();

            // Xử lý khi đặt hàng
            
            return View("/Views/Payment/checkout.cshtml");
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
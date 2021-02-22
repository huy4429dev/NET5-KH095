
using System.ComponentModel.DataAnnotations;
using System;

namespace KH095.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public Product product { set; get; }
    }
}
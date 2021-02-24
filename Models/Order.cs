using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace KH095.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Họ tên không được bỏ trống")]
        [MaxLength(255, ErrorMessage = "Họ tên không đúng định dạng")]
        public string FullName { get; set; }

        [MaxLength(200, ErrorMessage = "Địa chỉ không hợp lệ")]
        public string Address { get; set; }

        [MaxLength(10, ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }
        public OrderStatus Status { get; set; }
        public int? UserverifyId { get; set; }
        public User Userverify { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }

    public enum OrderStatus : byte
    {
        Success = 1,
        Dispose = 2,
        Borrowed = 3,
        NoProcess = 4,
        Overdue = 5

    }
}
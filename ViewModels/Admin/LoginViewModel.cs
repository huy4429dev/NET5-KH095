using System.ComponentModel.DataAnnotations;

namespace KH095.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        [MaxLength(255,ErrorMessage = "Tên đăng nhập không hợp lệ")]
        [MinLength(3,ErrorMessage = "Tên đăng nhập không hợp lệ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }
    }
}
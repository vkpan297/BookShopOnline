using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookOnline.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { get; set; }

        [StringLength(50)]
        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Bạn cần điền tên tài khoản")]
        public string UserName { get; set; }

        
        [DisplayName("Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhât 6 ký tự")]
        [Required(ErrorMessage = "Bạn cần điền mật khẩu")]
        public string Password { get; set; }

        [StringLength(50)]
        [DisplayName("Nhập lại mật khẩu")]
        [Compare("Password",ErrorMessage ="Xác nhận mật khẩu không đúng")]
        public string ConfirmPassword { get; set; }

        [StringLength(50)]
        [DisplayName("Tên")]
        [Required(ErrorMessage = "Bạn cần điền tên")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("Ðịa chỉ")]
        [Required(ErrorMessage = "Bạn cần điền địa chỉ")]
        public string Address { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Bạn cần điền email")]
        public string Email { get; set; }

        [StringLength(50)]
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Bạn cần điền số điện thoại")]
        public string Phone { get; set; }
    }
}
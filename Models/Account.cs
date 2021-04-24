
namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int ID { get; set; }

        [StringLength(50)]
        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Bạn cần điền tên tài khoản")]
       
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [StringLength(50)]
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Bạn cần điền mật khẩu")]
        public string Password { get; set; }

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
        [EmailAddress(ErrorMessage ="Địa chỉ email không đúng")]
        public string Email { get; set; }

        [StringLength(50)]
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Bạn cần điền số điện thoại")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Số điện thoại không phù hợp")]
        public string Phone { get; set; }

        [DisplayName("Ngày tạo")]
        [Required(ErrorMessage = "Bạn cần điền ngày tạo")]
        public DateTime? NgayTao { get; set; }
        [DisplayName("Trạng Thái")]
        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

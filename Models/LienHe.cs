namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienHe")]
    public partial class LienHe
    {
        [Key]
        [DisplayName("Mã Phản Hồi")]
        public int malh { get; set; }

        [StringLength(50)]
        [DisplayName("Tên Khách Hàng")]
        public string tennguoilh { get; set; }
        [DisplayName("Số điện thoại")]
        public int? sdtnguoilh { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        public string emailnguoilh { get; set; }

        [StringLength(50)]
        [DisplayName("Địa Chỉ")]
        public string diachinguoilh { get; set; }

        [StringLength(255)]
        [DisplayName("Nội Dung")]
        public string noidung { get; set; }

        public DateTime? ngaylh { get; set; }
    }
}

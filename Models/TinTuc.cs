namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        [DisplayName("Mã")]
        public int matt { get; set; }

        [StringLength(200)]
        [DisplayName("Tiêu dề")]
        [Required(ErrorMessage = "Bạn cần nhập Tiêu đề")]
        public string tieude { get; set; }

        [StringLength(100)]
        [DisplayName("Hình ảnh")]
        [Required(ErrorMessage = "Bạn cần chọn ảnh")]

        public string hinhanh { get; set; }

        [StringLength(900)]
        [DisplayName("Nội Dung")]
        [Required(ErrorMessage = "Bạn cần điền nội dung")]
        public string noidung { get; set; }
        [DisplayName("Ngày Ðăng")]
        public DateTime? ngaydang { get; set; }
    }
}
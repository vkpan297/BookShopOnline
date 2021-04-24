namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int IDSach { get; set; }

        [StringLength(50)]
        [DisplayName("Tên Sách")]
        [Required(ErrorMessage = "Bạn cần nhập Tên Sách")]
        public string TenSach { get; set; }

        [DisplayName("Số Lượng")]
        public int? SoLuong { get; set; }

        [DisplayName("Giá")]
        public int? Gia { get; set; }

        [DisplayName("Mã Loại")]
        public int? MaLoai { get; set; }

        [DisplayName("Số Tập")]
        public int? SoTap { get; set; }

        [StringLength(900)]
        [DisplayName("Ảnh")]
        [Required(ErrorMessage = "Bạn cần chọn ảnh")]
        public string Anh { get; set; }

        [DisplayName("Ngày Xuất Bản")]
        [Required(ErrorMessage = "Bạn cần điền ngày nhập")]
        public DateTime? NgayNhap { get; set; }

        [StringLength(50)]
        [DisplayName("Tác Giả")]
        [Required(ErrorMessage = "Bạn cần điền tác giả")]
        public string TacGia { get; set; }

        [StringLength(900)]
        [DisplayName("Mô Tả")]
        public string Mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual LoaiSach LoaiSach { get; set; }
    }
}
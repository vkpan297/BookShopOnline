namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [DisplayName("Mã Hoá Đơn")]
        public int MaHoaDon { get; set; }
        [DisplayName("Mã Khách Hàng")]
        public int? MaKh { get; set; }
        [DisplayName("Ngày Tạo")]
        public DateTime? NgayNhap { get; set; }

        [DisplayName("Trạng Thái")]
        public int? Status { get; set; }

        [StringLength(50)]
        [DisplayName("Tên Khách Hàng")]
        public string TenNguoiNhan { get; set; }

        [StringLength(50)]
        [DisplayName("Số điện thoại khách hàng")]
        public string SdtNguoiNhan { get; set; }

        [StringLength(50)]
        [DisplayName("Địa chỉ Khách Hàng")]
        public string DiaChiNguoiNhan { get; set; }

        [StringLength(50)]
        [DisplayName("Email Khách Hàng")]
        public string EmailNguoiNhan { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}

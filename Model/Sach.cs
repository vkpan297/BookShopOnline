namespace Model
{
    using System;
    using System.Collections.Generic;
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
        public string TenSach { get; set; }

        public int? SoLuong { get; set; }

        public int? Gia { get; set; }

        public int? MaLoai { get; set; }

        public int? SoTap { get; set; }

        [StringLength(250)]
        public string Anh { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(50)]
        public string Mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual LoaiSach LoaiSach { get; set; }
    }
}

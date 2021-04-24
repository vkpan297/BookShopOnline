namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int MaChiTietHoaDon { get; set; }

        public int? MaSach { get; set; }

        public int? MaHoaDon { get; set; }

        public int? SoLuongMua { get; set; }

        public int? Gia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Sach Sach { get; set; }
    }
}

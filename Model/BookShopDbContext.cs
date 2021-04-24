namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookShopDbContext : DbContext
    {
        public BookShopDbContext()
            : base("name=BookShopDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.MaKh);

            modelBuilder.Entity<LoaiSach>()
                .HasMany(e => e.Saches)
                .WithOptional(e => e.LoaiSach)
                .HasForeignKey(e => e.MaLoai);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithOptional(e => e.Sach)
                .HasForeignKey(e => e.MaSach);
        }
    }
}

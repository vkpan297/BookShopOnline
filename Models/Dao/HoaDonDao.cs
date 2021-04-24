using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.Dao;
using Models;
namespace Models.Dao
{
    public class HoaDonDao
    {
        BookShopDbContext db = null;
        public HoaDonDao()
        {
            db = new BookShopDbContext();
        }
        //public long Insert(HoaDon entity)
        //{
        //    db.HoaDons.Add(entity);
        //    db.SaveChanges();
        //    return entity.MaHoaDon;
        //}
        public int Insert(HoaDon hoadon)
        {
            db.HoaDons.Add(hoadon);
            db.SaveChanges();
            return hoadon.MaHoaDon;
        }

        public List<ChiTietHoaDon> Detail(int id)
        {
            return db.ChiTietHoaDons.Where(x => x.MaHoaDon == id).ToList();
           
        }
        public IEnumerable<ChiTietHoaDon> ListAllPagingCtHD(int page,int pagesize)
        {
            return db.ChiTietHoaDons.OrderBy(x => x.MaChiTietHoaDon).ToPagedList(page, pagesize);
        }
        public bool Delete(int id)
        {
            try
            {
                var sach = db.HoaDons.Find(id);
                db.HoaDons.Remove(sach);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<HoaDon> ListAllPaging( int page, int pagesize)
        {
            return db.HoaDons.OrderBy(x => x.MaHoaDon).ToPagedList(page, pagesize);
        }
        //public bool Update(HoaDon entity)
        //{
        //    try
        //    {
        //        var sach = db.HoaDons.Find(entity.MaHoaDon);
        //        sach.MaHoaDon = entity.MaHoaDon;
        //        sach.MaKh = entity.MaKh;
        //        sach.NgayNhap = entity.NgayNhap;
        //        sach.Status = entity.Status;
               
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}

        //public HoaDon GetById(string tensach)
        //{
        //    return db.HoaDons.SingleOrDefault(x => x.TenSach == tensach);
        //}

        public HoaDon ViewDetails(int id)
        {
            return db.HoaDons.Find(id);
        }
    }
}

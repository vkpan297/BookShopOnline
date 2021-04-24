using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.Dao;

namespace Models.Dao
{
    public class SachDao
    {
        BookShopDbContext db = null;
        public SachDao()
        {
            db = new BookShopDbContext();
        }
        public long Insert(Sach entity)
        {
            db.Saches.Add(entity);
            db.SaveChanges();
            return entity.IDSach;
        }

        public bool Delete(int id)
        {
            try
            {
                var sach = db.Saches.Find(id);
                db.Saches.Remove(sach);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Sach> ListAllPaging(string searchString,int page, int pagesize)
        {
            IQueryable<Sach> model = db.Saches;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.TenSach.Contains(searchString) || x.TacGia.Contains(searchString));
            }

            return model.OrderBy(x => x.IDSach).ToPagedList(page, pagesize);
        }
        
        public bool Update(Sach entity)
        {
            try
            {
                var sach = db.Saches.Find(entity.IDSach);
                sach.IDSach = entity.IDSach;
                sach.TenSach = entity.TenSach;
                sach.SoLuong = entity.SoLuong;
                sach.Gia = entity.Gia;
                sach.MaLoai = entity.MaLoai;
                sach.SoTap = entity.SoTap;
                sach.Anh = entity.Anh;
                sach.NgayNhap = entity.NgayNhap;
                sach.TacGia = entity.TacGia;
                sach.Mota = entity.Mota;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        public Sach GetById(string tensach)
        {
            return db.Saches.SingleOrDefault(x => x.TenSach == tensach);
        }

        public Sach ViewDetails(int id)
        {
            return db.Saches.Find(id);
        }
        public Sach Detail(int id)
        {
            var rs = db.Saches.SingleOrDefault(x => x.IDSach == id);
            return rs;
        }
        public bool Upload(int id, string imgname)
        {
            var sp = db.Saches.SingleOrDefault(x => x.IDSach == id);
            if (sp != null)
            {
                sp.Anh = imgname;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

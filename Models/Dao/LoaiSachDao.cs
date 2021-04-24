using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.Dao;

namespace Models.Dao
{
    public class LoaiSachDao
    {
        BookShopDbContext db = null;
        public LoaiSachDao()
        {
            db = new BookShopDbContext();
        }

   
        public List<LoaiSach> ListOf()
        {
            return db.LoaiSaches.ToList();

        }

        public long Insert(LoaiSach entity)
        {
            db.LoaiSaches.Add(entity);
            db.SaveChanges();
            return entity.IDLoai;
        }

        public bool Delete(int id)
        {
            try
            {
                var sach = db.LoaiSaches.Find(id);
                db.LoaiSaches.Remove(sach);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<LoaiSach> ListAllPaging(string searchString, int page, int pagesize)
        {
            IQueryable<LoaiSach> model = db.LoaiSaches;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.TenLoai.Contains(searchString));
            }

            return model.OrderBy(x => x.IDLoai).ToPagedList(page, pagesize);
        }
        public bool Update(LoaiSach entity)
        {
            try
            {
                var sach = db.LoaiSaches.Find(entity.IDLoai);
                sach.IDLoai = entity.IDLoai;
                sach.TenLoai = entity.TenLoai;
               
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public LoaiSach GetById(string tensach)
        {
            return db.LoaiSaches.SingleOrDefault(x => x.TenLoai == tensach);
        }

        public LoaiSach ViewDetails(int id)
        {
            return db.LoaiSaches.Find(id);
        }
    }
}

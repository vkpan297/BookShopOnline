using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.Dao;
namespace Models.Dao
{
   public class TinTucDao
    {
        BookShopDbContext db = null;
        public TinTucDao()
        {
            db = new BookShopDbContext();
        }
        public long Insert(TinTuc entity)
        {
            db.TinTucs.Add(entity);
            db.SaveChanges();
            return entity.matt;
        }

        public bool Delete(int id)
        {
            try
            {
                var sach = db.TinTucs.Find(id);
                db.TinTucs.Remove(sach);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<TinTuc> ListAllPaging(string searchString, int page, int pagesize)
        {
            IQueryable<TinTuc> model = db.TinTucs;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.tieude.Contains(searchString));
            }

            return model.OrderBy(x => x.matt).ToPagedList(page, pagesize);
        }
        public bool Update(TinTuc entity)
        {
            try
            {
                var sach = db.TinTucs.Find(entity.matt);
                sach.matt = entity.matt;
                sach.tieude = entity.tieude;
                sach.hinhanh = entity.hinhanh;
                sach.noidung = entity.noidung;
                sach.ngaydang = entity.ngaydang;
                
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public TinTuc GetById(string tensach)
        {
            return db.TinTucs.SingleOrDefault(x => x.tieude == tensach);
        }

        public TinTuc ViewDetails(int id)
        {
            return db.TinTucs.Find(id);
        }

        public List<TinTuc> DetailClient(int id)
        {
            return db.TinTucs.Where(x => x.matt == id).ToList();

        }
        public TinTuc Detail(int id)
        {
            var rs = db.TinTucs.SingleOrDefault(x => x.matt == id);
            return rs;

        }
        public bool Upload(int id, string imgname)
        {
            var sp = db.TinTucs.SingleOrDefault(x => x.matt == id);
            if (sp != null)
            {
                sp.hinhanh = imgname;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public List<TinTuc> ListRelateProducts(int proID)
        {
            var pro = db.TinTucs.Find(proID);
            return db.TinTucs.Where(x => x.matt != proID).ToList();
        }
    }
}

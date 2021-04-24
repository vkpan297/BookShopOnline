using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.Dao;

namespace Models.Dao
{
    public class LienHeDao
    {
        BookShopDbContext db = null;
        public LienHeDao()
        {
            db = new BookShopDbContext();
        }

        public int AddNew(LienHe obj)
        {
            db.LienHes.Add(obj);
            db.SaveChanges();
            return obj.malh;
        }
        public bool Delete(int malh)
        {
            try
            {
                var lh = db.LienHes.Find(malh);
                db.LienHes.Remove(lh);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<LienHe> ListAllPaging(string searchString, int page, int pagesize)
        {
            IQueryable<LienHe> model = db.LienHes;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.tennguoilh.Contains(searchString) || x.emailnguoilh.Contains(searchString));
            }

            return model.OrderBy(x => x.malh).ToPagedList(page, pagesize);
        }
    }
}

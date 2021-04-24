using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using PagedList;
namespace Models.Dao
{
    public class SachClientDao
    {
        BookShopDbContext db=null;
        public SachClientDao()
        {
            db = new BookShopDbContext();
        }
        
        public IEnumerable<Sach> ListByCategoryID( long id, int page, int pagesize)
        {           
            return db.Saches.Where(x => x.MaLoai == id).OrderBy(x=>x.IDSach).ToPagedList(page, pagesize);        
        }
     
        public List<Sach> ListHotSach(int hot)
        {
            return db.Saches.OrderByDescending(x => x.NgayNhap).Take(hot).ToList();
        }
        public List<Sach> ListRelateProducts(int proID)
        {
            var pro = db.Saches.Find(proID);
            return db.Saches.Where(x=>x.IDSach != proID && x.MaLoai==pro.MaLoai).ToList();
        }

        public Sach ViewDetail(int id)
        {
            return db.Saches.Find(id);
        }

        public List<Sach> SearchByName(string name)
        {
            return db.Saches.Where(x => x.TenSach.Contains(name)).ToList();
        }

    }
}

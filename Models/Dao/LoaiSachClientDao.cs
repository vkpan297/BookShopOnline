using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.Dao
{
    public class LoaiSachClientDao
    {
        BookShopDbContext db = null;
        public LoaiSachClientDao()
        {
            db = new BookShopDbContext();
        }
        public List<LoaiSach> ListAll()
        {
            return db.LoaiSaches.OrderBy(x => x.IDLoai).ToList();  
        }
        public LoaiSach ViewDetail(long id)
        {
            return db.LoaiSaches.Find(id);
        }

    }
}

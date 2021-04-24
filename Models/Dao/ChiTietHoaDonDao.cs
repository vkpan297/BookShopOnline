using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Dao;
using Models;
namespace Models.Dao
{
    public class ChiTietHoaDonDao
    {
        BookShopDbContext db = null;
        public ChiTietHoaDonDao()
        {
            db = new BookShopDbContext();
        }
        
        public bool Insert(ChiTietHoaDon chitiet)
        {
            try
            {
                db.ChiTietHoaDons.Add(chitiet);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        
        }
    }
}

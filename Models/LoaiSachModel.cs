using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   
    public class LoaiSachModel
    {
        private BookShopDbContext ct1 = null;

        public LoaiSachModel()
        {
            ct1 = new BookShopDbContext();
        }

        public List<LoaiSach> ListAll()
        {
            var list = ct1.Database.SqlQuery<LoaiSach>("Sp_LoaiSach_ListAll").ToList();
            return list;
        }
    }
}

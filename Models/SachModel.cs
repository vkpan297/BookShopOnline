using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SachModel
    {
        private BookShopDbContext ct = null;

        public SachModel()
        {
            ct = new BookShopDbContext();
        }

        public List<Sach> ListAll()
        {
            var list = ct.Database.SqlQuery<Sach>("Sp_sach_ListAll").ToList();
            return list;
        }

    }
}

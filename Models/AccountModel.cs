using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModel
    {
        private BookShopDbContext ct = null;

        public AccountModel()
        {
            ct = new BookShopDbContext();
        }
      
        public bool Login(string Username, string Password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@Username", Username),
                new SqlParameter("@Password", Password),
            };
            var res = ct.Database.SqlQuery<bool>("Sp_Account_Login @Username,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class UserDao
    {
        BookShopDbContext db = null;
        public UserDao()
        {
            db = new BookShopDbContext();
        }
        public long Insert(Account entity)
        {
            db.Accounts.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public Account GetByID(string userName)
        {
            return db.Accounts.SingleOrDefault(x => x.UserName == userName);
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.Accounts.Count(x => x.UserName == userName && x.Password == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckPhone(string phone)
        {
            return db.Accounts.Count(x => x.Phone == phone) > 0;
        }
        public bool CheckEmail(string Email)
        {
            return db.Accounts.Count(x => x.Email == Email) > 0;
        }
        public List<ChiTietHoaDon> Detail(int id)
        {
            return db.ChiTietHoaDons.Where(x => x.HoaDon.MaKh == id).ToList();

        }

        public List<Account> DetailAccount(int id)
        {
            return db.Accounts.Where(x => x.ID == id).ToList();

        }
        //public List<Account> ListOf()
        //{
        //    return db.Accounts.ToList();

        //}
    }
}

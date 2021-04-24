using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.Dao;

namespace Models.Dao
{
    public class AccountDao
    {
        BookShopDbContext db = null;
        public AccountDao()
        {
            db = new BookShopDbContext();
        }
        public long Insert(Account entity)
        {
            db.Accounts.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        //public int AddNew(Account obj)
        //{
        //    db.Accounts.Add(obj);
        //    db.SaveChanges();
        //    return obj.ID;
        //}

        public bool Delete(int id)
        {
            try
            {
                var acc = db.Accounts.Find(id);
                if (acc.Status == 1)
                {
                    db.Accounts.Remove(acc);
                    db.SaveChanges();                   
                }
                
    
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Account> ListAllPaging(string searchString, int page, int pagesize)
        {
            IQueryable<Account> model = db.Accounts;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.UserName.Contains(searchString)|| x.Name.Contains(searchString));
            }

            return model.OrderBy(x => x.ID).ToPagedList(page, pagesize);
        }
        //public bool Update(LoaiSach entity)
        //{
        //    try
        //    {
        //        var sach = db.LoaiSaches.Find(entity.IDLoai);
        //        sach.IDLoai = entity.IDLoai;
        //        sach.TenLoai = entity.TenLoai;

        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}

        public Account GetById(string ten)
        {
            return db.Accounts.SingleOrDefault(x => x.Name == ten);
        }

        public Account ViewDetails(int id)
        {
            return db.Accounts.Find(id);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Dao;
using PagedList;
namespace BookOnline.Controllers
{
    public class SachClientController : Controller
    {
        // GET: SachClient
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult LoaiSach()
        {
            var model = new LoaiSachClientDao().ListAll();
            return PartialView(model);
        }
        public  ActionResult Loai(long id, int page = 1, int pagesize = 4)
        {
            var cate = new LoaiSachClientDao().ViewDetail(id);
            ViewBag.Loai = cate;          
            var model = new SachClientDao().ListByCategoryID(id, page, pagesize);         
            return View(model);
        }

            
        public ActionResult ChiTietSach(int id)
        {
            var cate = new SachClientDao().ViewDetail(id);
            ViewBag.Loai = new LoaiSachClientDao().ViewDetail(cate.MaLoai.Value);
            ViewBag.ListRelateProducts = new SachClientDao().ListRelateProducts(id);
            return View(cate);
        }
        public ActionResult Search(string NoiDungTim)
        {
            SachClientDao dao = new SachClientDao();
            var res = dao.SearchByName(NoiDungTim);
            return View(res);
        }


    }
}
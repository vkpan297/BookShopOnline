using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookOnline.Controllers
{
    public class TinTucClientController : Controller
    {
      
        // GET: TinTucClient
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new TinTucDao();
            var model = dao.ListAllPaging(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
 

        public ActionResult Detail(int id)
        {
            var cate = new TinTucDao().ViewDetails(id);
           
            ViewBag.ListRelateProducts = new TinTucDao().ListRelateProducts(id);
            return View(cate);
            
        }
        //public ActionResult Detail(int id)
        //{
        //    TinTucDao dao = new TinTucDao();
        //    var rs = dao.DetailClient(id);
        //    //if (rs != null)
        //    //{
        //    //    ViewBag.Detail = rs;
        //    //}
        //    return View(rs);
        //}
    }
}
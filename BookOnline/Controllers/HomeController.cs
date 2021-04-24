using BookOnline.Areas.Admin.Common;
using BookOnline.Models;
using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookOnline.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var sachDao = new SachClientDao();
            ViewBag.HotBook = sachDao.ListHotSach(4);
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[CommonConstant.CartSession];
            var list = new List<Cartitem>();
            if (cart != null)
            {
                list = (List<Cartitem>)cart;
            }
            return PartialView(list);
        }
    }
}
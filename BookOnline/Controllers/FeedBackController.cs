using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Models.Dao;

namespace BookOnline.Controllers
{
    public class FeedBackController : Controller
    {
        // GET: FeedBack
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
       
            return View();
        }
        [HttpPost]
        public ActionResult Add(LienHe sp)
        {
            //LienHeDao dao = new LienHeDao();
            //int newID = dao.AddNew(sp);
            //if (newID != -1)
            //{
            //    ViewBag.Message = "Them Moi Thanh Cong";

            //}
            //else
            //{
            //    ViewBag.Message = "Them Moi ko Thanh Cong";
            //}
            //return RedirectToAction("Index", "Home");

            try
            {
                if (ModelState.IsValid)
                {                   
                    var dao = new LienHeDao();

                    var user = new LienHe();
                    user.tennguoilh = sp.tennguoilh;
                    user.sdtnguoilh = sp.sdtnguoilh;
                    user.emailnguoilh = sp.emailnguoilh;
                    user.diachinguoilh = sp.diachinguoilh;
                    user.noidung = sp.noidung;
                    user.ngaylh = DateTime.Now;


                    var res = dao.AddNew(user);
                    if (res > 0)
                    {
                        ViewBag.Success = "Đăng Ký Thành Công";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng Ký Khong Thành Công");
                    }
                }



                return View(sp);
            }
            catch
            {
                return View("Index");
            }

        }
    }
}
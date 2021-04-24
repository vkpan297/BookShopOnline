using BookOnline.Models;
using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BotDetect.Web.Mvc;
using BookOnline.Areas.Admin.Common;

namespace BookOnline.Controllers
{
    public class UserController : Controller
    {

        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session[CommonConstant.USER_SESSION] = null;
            return Redirect("/");
        }
        public ActionResult DetailAccount(int id)
        {
            UserDao dao = new UserDao();
            var rs = dao.DetailAccount(id);
            //if (rs != null)
            //{
            //    ViewBag.Detail = rs;
            //}
            return View(rs);
        }
        public ActionResult Detail(int id)
        {
            UserDao dao = new UserDao();
            var rs = dao.Detail(id);
            //if (rs != null)
            //{
            //    ViewBag.Detail = rs;
            //}
            return View(rs);
        }
        [HttpPost]

        [CaptchaValidation("CaptchaCode","registerCapcha","Mã xác nhận không đúng!")]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckPhone(model.Phone))
                {
                    ModelState.AddModelError("", "Số điện thoại đã tồn tại");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var user = new Account();
                    user.UserName = model.UserName;
                    user.Password = model.Password;
                    user.Name = model.Name;
                    user.Phone = model.Phone;
                    user.Address = model.Address;
                    user.Email = model.Email;
                    user.NgayTao = DateTime.Now;
                    
                    var res = dao.Insert(user);
                    if (res > 0)
                    {
                        ViewBag.Success = "Đăng Ký Thành Công";
                        model = new RegisterModel();
                        ModelState.Clear();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng Ký Khong Thành Công");
                    }
                }
            }
            return View();
        }
        
    }
}
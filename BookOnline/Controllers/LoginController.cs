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
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Login(model.username, model.pass);
                if (res)
                {
                    var user = dao.GetByID(model.username);
                    var userSession = new UserLogin();
                    if (user.Status == 1)
                    {
                        userSession.username = user.UserName;
                        userSession.ID = user.ID;
                        userSession.Name = user.Name;
                        userSession.Phone = user.Phone;
                        userSession.Email = user.Email;
                        userSession.Address = user.Address;
                        userSession.sta = user.Status;
                        Session.Add(CommonConstant.USER_SESSION, userSession);
                        return RedirectToAction("Sach", "Admin");
                    }
                    else
                    {
                        userSession.username = user.UserName;
                        userSession.ID = user.ID;
                        userSession.Name = user.Name;
                        userSession.Phone = user.Phone;
                        userSession.Email = user.Email;
                        userSession.Address = user.Address;
                        userSession.sta = user.Status;
                        Session.Add(CommonConstant.USER_SESSION, userSession);
                        return RedirectToAction("Index", "Home");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "That Bai");
                }
            }
            return View("Index");

        }
    }
}
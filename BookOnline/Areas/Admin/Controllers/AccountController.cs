using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookOnline.Areas.Admin.Common;
using Models;
using Models.Dao;
using PagedList;
namespace BookOnline.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new AccountDao();
            var model = dao.ListAllPaging(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        // GET: Admin/Sach/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        // GET: Admin/Sach/Create
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Logout()
        {
            Session[CommonConstant.USER_SESSION] = null;
            return Redirect("/");
        }

        //public ActionResult Edit(int id)
        //{
        //    var Loaisach = new LoaiSachDao().ViewDetails(id);
        //    return View(Loaisach);
        //}

        // POST: Admin/Sach/Create
        [HttpPost]
        public ActionResult Create(Account collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var dao = new AccountDao();
                    long id = dao.Insert(collection);
                    if (id > 0)
                    {
                        SetAlert("Thêm thành công", "success");
                        return RedirectToAction("Index", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm tài khoản không thành công");
                    }


                }
                return View(collection);
            }
            catch
            {
                return View("Index");
            }




            //var dao = new AccountDao();

            //var user = new Account();
            //user.UserName = collection.UserName;
            //user.Password = collection.Password;
            //user.Name = collection.Name;
            //user.Address = collection.Address;
            //user.Email = collection.Email;
            //user.Phone = collection.Phone;
            //user.NgayTao = DateTime.Now;
            //user.Status = collection.Status;



            //var res = dao.AddNew(user);
            //if (res > 0)
            //{
            //ViewBag.Success = "Đăng Ký Thành Công";
            //return RedirectToAction("Index", "Account");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Đăng Ký Không Thành Công");
            //}






        }

        // GET: Admin/Sach/Edit/5


        // POST: Admin/Sach/Edit/5
        //[HttpPost]
        //public ActionResult Edit(LoaiSach collection)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            // TODO: Add insert logic here
        //            var dao = new LoaiSachDao();
        //            var result = dao.Update(collection);
        //            if (result)
        //            {
        //                return RedirectToAction("Index", "LoaiSach");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Cập nhật sản phẩm không thành công");
        //            }


        //        }
        //        return View(collection);
        //    }
        //    catch
        //    {
        //        return View("Index");
        //    }
        //}

        // GET: Admin/Sach/Delete/5
        //public ActionResult Delete()
        //{
        //    return View();
        //}

        // POST: Admin/Sach/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {           
                new AccountDao().Delete(id);          
                SetAlert("Xóa thành công", "success");
                return RedirectToAction("Index");
        }
        protected void SetAlert(string message,string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }

    }
}

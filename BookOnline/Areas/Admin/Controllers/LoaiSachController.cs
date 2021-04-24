using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Models.Dao;
using PagedList;
namespace BookOnline.Areas.Admin.Controllers
{
    public class LoaiSachController : Controller
    {
        // GET: Admin/LoaiSach
        //public ActionResult Index()
        //{
        //    var ls1 = new LoaiSachModel();
        //    var ls2 = ls1.ListAll();
        //    return View(ls2);
        //}

 

        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new LoaiSachDao();
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

        public ActionResult Edit(int id)
        {
            var Loaisach = new LoaiSachDao().ViewDetails(id);
            return View(Loaisach);
        }

        // POST: Admin/Sach/Create
        [HttpPost]
        public ActionResult Create(LoaiSach collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var dao = new LoaiSachDao();
                    long id = dao.Insert(collection);
                    if (id > 0)
                    {
                        SetAlert("Thêm thành công", "success");
                        return RedirectToAction("Index", "LoaiSach");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm sản phẩm không thành công");
                    }


                }
                return View(collection);
            }
            catch
            {
                return View("Index");
            }

        }

        // GET: Admin/Sach/Edit/5


        // POST: Admin/Sach/Edit/5
        [HttpPost]
        public ActionResult Edit(LoaiSach collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var dao = new LoaiSachDao();
                    var result = dao.Update(collection);
                    if (result)
                    {
                        SetAlert("Sửa thành công", "success");
                        return RedirectToAction("Index", "LoaiSach");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Cập nhật sản phẩm không thành công");
                    }


                }
                return View(collection);
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Admin/Sach/Delete/5
        //public ActionResult Delete()
        //{
        //    return View();
        //}

        // POST: Admin/Sach/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {


            new LoaiSachDao().Delete(id);
            // TODO: Add delete logic here
            SetAlert("Xóa thành công", "success");
            return RedirectToAction("Index");


        }
        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warning")
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

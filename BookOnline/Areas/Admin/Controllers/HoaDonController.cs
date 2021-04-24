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
    public class HoaDonController : Controller
    {
        // GET: Admin/HoaDon
        public ActionResult Index( int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new HoaDonDao();
            var model = dao.ListAllPaging(page, pagesize);
            
            return View(model);
        }

        public ActionResult ListCTHD(int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new HoaDonDao();
            var model = dao.ListAllPagingCtHD(page, pagesize);

            return View(model);
        }

        // GET: Admin/Sach/Details/5
        public ActionResult Detail(int id)
        {
            HoaDonDao dao = new HoaDonDao();
            var rs = dao.Detail(id);
            //if (rs != null)
            //{
            //    ViewBag.Detail = rs;
            //}
            return View(rs);
        }
        [HttpGet]
        // GET: Admin/Sach/Create
        public ActionResult Create()
        {

            return View();
        }

        //public ActionResult Edit(int id)
        //{
        //    var sach = new HoaDonDao().ViewDetails(id);
        //    return View(sach);
        //}

        // POST: Admin/Sach/Create
        [HttpPost]
        //public ActionResult Create(HoaDon collection)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            // TODO: Add insert logic here
        //            var dao = new HoaDonDao();
        //            long id = dao.Insert(collection);
        //            if (id > 0)
        //            {
        //                return RedirectToAction("Index", "HoaDon");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Thêm không thành công");
        //            }


        //        }
        //        return View(collection);
        //    }
        //    catch
        //    {
        //        return View("Index");
        //    }

        //}

        // GET: Admin/Sach/Edit/5


        // POST: Admin/Sach/Edit/5
        //[HttpPost]
        //public ActionResult Edit(HoaDon collection)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            // TODO: Add insert logic here
        //            var dao = new HoaDonDao();
        //            var result = dao.Update(collection);
        //            if (result)
        //            {
        //                return RedirectToAction("Index", "HoaDon");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Cập nhật không thành công");
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


            new HoaDonDao().Delete(id);
            // TODO: Add delete logic here

            return RedirectToAction("Index");


        }
    }
}

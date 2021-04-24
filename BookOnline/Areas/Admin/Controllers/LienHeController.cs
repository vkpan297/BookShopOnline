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
    public class LienHeController : Controller
    {
        // GET: Admin/LienHe
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new LienHeDao();
            var model = dao.ListAllPaging(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        // GET: Admin/LienHe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/LienHe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LienHe/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LienHe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/LienHe/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LienHe/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Admin/LienHe/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {


            new LienHeDao().Delete(id);
            // TODO: Add delete logic here

            return RedirectToAction("Index");


        }
    }
}

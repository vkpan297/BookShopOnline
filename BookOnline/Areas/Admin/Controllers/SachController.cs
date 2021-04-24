using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Models.Dao;
using PagedList;

namespace BookOnline.Areas.Admin.Controllers
{
    public class SachController : Controller
    {
        //GET: Admin/Sach
        //public ActionResult Index()
        //{
        //    var iplCate = new SachModel();
        //    var model = iplCate.ListAll();
        //    return View(model);
        //}

           
        public ActionResult Index(string searchString,int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new SachDao();
            var model = dao.ListAllPaging(searchString,page, pagesize);
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
            LoaiSachDao lsp1 = new LoaiSachDao();
            var lSp1 = lsp1.ListOf();

            ViewBag.LSP = lSp1;           
            return View();
        }

        public ActionResult Edit(int id)
        {
            LoaiSachDao lsp = new LoaiSachDao();
            var lSp = lsp.ListOf();

            

         
            ViewBag.LSP = lSp;

            SachDao dao = new SachDao();
            var sp = dao.Detail(id);

            return View(sp);
        }

        // POST: Admin/Sach/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Sach collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var dao = new SachDao();
                    long id = dao.Insert(collection);
                    if (id > 0)
                    {

                        SetAlert("Thêm thành công", "success");
                        return RedirectToAction("Index", "Sach");
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
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(Sach collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var dao = new SachDao();
                    var result = dao.Update(collection);
                    if (result)
                    {
                        SetAlert("Sửa thành công", "success");
                        return RedirectToAction("Index", "Sach");
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
            
          
                new SachDao().Delete(id);
            // TODO: Add delete logic here
            SetAlert("Xóa thành công", "success");
            return RedirectToAction("Index");
            
         
        }
        public ActionResult Detail(int id)
        {
            SachDao dao = new SachDao();
            var rs = dao.Detail(id);
            if (rs != null)
            {
                ViewBag.Detail = rs;
            }
            return View();
        }
        public ActionResult Upload(int id)
        {
            SachDao dao = new SachDao();
            var sp = dao.Detail(id);
            return View(sp);
        }

        [HttpPost]

        public ActionResult Upload(HttpPostedFileBase file, Sach obj)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    fileName += "_" + obj.IDSach;
                    fileName += Path.GetExtension(file.FileName);
                    string folderPath = Server.MapPath("~") + @"\images\image";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string path = Path.Combine(folderPath, fileName);

                    file.SaveAs(path);
                    var dao = new SachDao();
                    dao.Upload(obj.IDSach, fileName);
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception ex)
            {
                return View(obj);
            }
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

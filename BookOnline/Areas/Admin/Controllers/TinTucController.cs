using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Models.Dao;
using PagedList;
using System.IO;

namespace BookOnline.Areas.Admin.Controllers
{
    public class TinTucController : Controller
    {
        // GET: Admin/TinTuc
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            //var iplCate = new SachModel();
            //var model = iplCate.ListAll();
            var dao = new TinTucDao();
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
            var sach = new TinTucDao().ViewDetails(id);
            return View(sach);
        }

        // POST: Admin/Sach/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(TinTuc collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    //var dao = new TinTucDao();
                    //long id = dao.Insert(collection);
                    //if (id > 0)
                    //{
                    //    return RedirectToAction("Index", "TinTuc");
                    //}
                    //else
                    //{
                    //    ModelState.AddModelError("", "Thêm không thành công");
                    //}


                    var dao = new TinTucDao();
        
                        var user = new TinTuc();
                        user.tieude = collection.tieude;
                        user.hinhanh = collection.hinhanh;
                        user.noidung = collection.noidung;
                        user.ngaydang = DateTime.Now;
                        

                        var res = dao.Insert(user);
                        if (res > 0)
                        {
                        SetAlert("Thêm thành công", "success");
                        return RedirectToAction("Index", "TinTuc");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Đăng Ký Khong Thành Công");
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
        public ActionResult Edit(TinTuc collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var dao = new TinTucDao();
                    var result = dao.Update(collection);
                    if (result)
                    {
                        SetAlert("Sửa thành công", "success");
                        return RedirectToAction("Index", "TinTuc");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Cập nhật không thành công");
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


            new TinTucDao().Delete(id);
            // TODO: Add delete logic here
            SetAlert("Xóa thành công", "success");
            return RedirectToAction("Index");


        }
        public ActionResult Detail(int id)
        {
            TinTucDao dao = new TinTucDao();
            var rs = dao.Detail(id);
            if (rs != null)
            {
                ViewBag.Detail = rs;
            }
            return View();
        }
        public ActionResult Upload(int id)
        {
            TinTucDao dao = new TinTucDao();
            var sp = dao.Detail(id);
            return View(sp);
        }

        [HttpPost]

        public ActionResult Upload(HttpPostedFileBase file, TinTuc obj)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    fileName += "_" + obj.matt;
                    fileName += Path.GetExtension(file.FileName);
                    string folderPath = Server.MapPath("~") + @"\AnhTinTuc\anhtintuc";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string path = Path.Combine(folderPath, fileName);

                    file.SaveAs(path);
                    var dao = new TinTucDao();
                    dao.Upload(obj.matt, fileName);
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

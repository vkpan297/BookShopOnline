using BookOnline.Models;
using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Models;
using BookOnline.Areas.Admin.Common;

namespace BookOnline.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<Cartitem>();
            if (cart != null)
            {
                list = (List<Cartitem>)cart;
            }
            return View(list);
        }

        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Delete(long id)
        {
            var sessionCart = (List<Cartitem>)Session[CartSession];
            sessionCart.RemoveAll(x => x.Sach.IDSach == id);
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<Cartitem>>(cartModel);
            var sessionCart = (List<Cartitem>)Session[CartSession];
            
            foreach(var item in sessionCart)
            {
                
                var jsonItem = jsonCart.SingleOrDefault(x => x.Sach.IDSach == item.Sach.IDSach);
                if(jsonItem != null)
                {
                    
                    item.SoLuong =jsonItem.SoLuong;

                }
                
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public ActionResult AddItem(int IDSach, int SoLuong)
        {
            var sach = new SachClientDao().ViewDetail(IDSach);
            var cart = Session[CartSession];
            if (cart!=null)
            {
                
                var list = (List<Cartitem>)cart;
                if (list.Exists(x => x.Sach.IDSach == IDSach))
                {
                    foreach (var item in list)
                    {
                        if (item.Sach.IDSach == IDSach)
                        {
                            item.SoLuong += SoLuong;
                        }
                    }
                }
                else
                {
                    var item = new Cartitem();
                    item.Sach = sach;
                    item.SoLuong = SoLuong;
                    list.Add(item);
                }
                Session[CartSession] = list;
            }
            else
            {
                //tạo mới dối tượng cart item
                var item = new Cartitem();
                item.Sach = sach;
                item.SoLuong = SoLuong;
                var list = new List<Cartitem>();
                list.Add(item);
                //Gán vào session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Payment()
        {
            var session = (UserLogin)Session[CommonConstant.USER_SESSION];
            if (session == null)
            {
                return RedirectToAction("Index", "Login");
                //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "lgn", Action = "Index" }));
            }
            var cart = Session[CartSession];
            var list = new List<Cartitem>();
            if (cart != null)
            {
                list = (List<Cartitem>)cart;
            }
            return View(list);
            
        }

        [HttpPost]
        public ActionResult Payment(int idkh, string tenkh, string sdt, string diachi, string email)
        {
            var order = new HoaDon();
            order.MaKh = idkh;
            order.NgayNhap = DateTime.Now;
            order.TenNguoiNhan = tenkh;
            order.SdtNguoiNhan = sdt;
            order.DiaChiNguoiNhan = diachi;
            order.EmailNguoiNhan = email;

            var id = new HoaDonDao().Insert(order);
            var cart =(List<Cartitem>)Session[CartSession];
            var chitiet = new ChiTietHoaDonDao();
            foreach(var item in cart)
            {
                var cthoadon = new ChiTietHoaDon();
                cthoadon.MaSach = item.Sach.IDSach;
                cthoadon.MaHoaDon = id;
                cthoadon.SoLuongMua = item.SoLuong;
                cthoadon.Gia = item.Sach.Gia * item.SoLuong;
                chitiet.Insert(cthoadon);


            }
            return Redirect("/hoan-thanh");

        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
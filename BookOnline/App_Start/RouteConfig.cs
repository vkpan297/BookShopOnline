using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{*botdetect}",
                new { botdetect=@"(.*)BotDetectCaptcha\.ashx"  });

            routes.MapRoute(
                name: "Loai Sach",
                url: "san-pham/{id}",
                defaults: new { controller = "SachClient", action = "Loai", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Chi Tiet San Pham",
                url: "chi-tiet/{TenSach}-{id}",
                defaults: new { controller = "SachClient", action = "ChiTietSach", id = UrlParameter.Optional }
            );
      
            routes.MapRoute(
               name: "Tin tuc",
               url: "tin-tuc",
               defaults: new { controller = "TinTucClient", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Update Giỏ Hàng",
               url: "gio-hang",
               defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Payment",
               url: "thanh-toan",
               defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Register",
               url: "dang-ky",
               defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "PaymentSuccess",
               url: "hoan-thanh",
               defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Giỏ Hàng",
               url: "them-gio-hang",
               defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

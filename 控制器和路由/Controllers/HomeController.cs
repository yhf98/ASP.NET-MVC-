using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 控制器和路由.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            HttpCookie cookie = Request.Cookies["theme"]??new HttpCookie("theme","default");
            ViewBag.theme = cookie.Value;

            return View();
        }

        [HttpPost]
        public ActionResult Index(string theme)
        {
            HttpCookie cookie = new HttpCookie("theme",theme);
            cookie.Expires = DateTime.MaxValue;
            Response.SetCookie(cookie);
            ViewBag.theme = cookie.Value;
            return View();
        }

        
        public ActionResult Css()
        {
            HttpCookie cookie = Request.Cookies["theme"]??new HttpCookie("theme","default");

            switch (cookie.Value)
            {
                case "theme1":

                    return Content("body{font-family:SimHei;font-size:1.2em;color:red;}","text/css");

                case "theme2":

                    return Content("body{font-family:KaiTi;font-size:2.2em;color:green;}", "text/css");

                default:

                    return Content("body{font-family:SimSong;font-size:3.2em;color:blue;}", "text/css");
            }
        }

        public ActionResult Image(string id)
        {
            if (string.IsNullOrEmpty(id)) return View();
            string path = Server.MapPath("/Images/" + id+".png");
            FileResult file= File(path, "image/png");
            return file;
        }

        public ActionResult Down(string id)
        {
            string path = Server.MapPath("/Images/" + id + ".png");

            string name = Path.GetFileName(path);

            
            
            return File(path,"image/png",name);
        }

     
    }
}
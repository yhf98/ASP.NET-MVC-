using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 过滤器.Filter;

namespace 过滤器.Controllers
{
    public class HomeController : Controller
    {
        [Login(IsChecked =true)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string username,string pwd)
        {
            if (username == "123" && pwd == "123")
            {
                Session["username"] = "123";
                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.msg = "密码错误！";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
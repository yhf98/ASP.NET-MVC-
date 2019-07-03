using ASP.NET_AJAX的应用.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_AJAX的应用.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return View();
            }
            using (meixinEntities db = new meixinEntities())
            {
                var goods = db.m_product.ToList();
                var result = goods.FindAll(F => F.pname.Contains(""));
                return PartialView("_source", result);
            }
        }

        public ActionResult Go()
        {

            ViewBag.Items = new string [] {"王二狗","WANNNG", "王二狗", "WANNNG", "王二狗", "WANNNG" };

            return PartialView("_data");
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
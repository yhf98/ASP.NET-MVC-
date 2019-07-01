using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 过滤器.Filter
{
    public class Login:ActionFilterAttribute
    {
        public bool IsChecked { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (IsChecked)
            {
                if (filterContext.HttpContext.Session["username"] == null)
                {
                    filterContext.HttpContext.Response.Redirect("/Home/Login");
                }
            }
        }
    }
}
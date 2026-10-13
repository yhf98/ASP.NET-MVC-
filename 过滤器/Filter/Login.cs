using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace 过滤器.Filter
{
    public class Login : ActionFilterAttribute
    {
        public bool IsChecked { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (IsChecked)
            {
                if (filterContext.HttpContext.Session.GetString("username") == null)
                {
                    filterContext.Result = new RedirectResult("/Home/Login");
                }
            }
        }
    }
}

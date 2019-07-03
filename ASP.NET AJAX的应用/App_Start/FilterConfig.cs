using System.Web;
using System.Web.Mvc;

namespace ASP.NET_AJAX的应用
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

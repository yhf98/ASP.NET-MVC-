using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            ViewBag.theme = Request.Cookies["theme"] ?? "default";

            return View();
        }

        [HttpPost]
        public IActionResult Index(string theme)
        {
            theme ??= "default";
            Response.Cookies.Append("theme", theme, new CookieOptions { Expires = DateTimeOffset.MaxValue });
            ViewBag.theme = theme;
            return View();
        }

        public IActionResult Css()
        {
            switch (Request.Cookies["theme"])
            {
                case "theme1":

                    return Content("body{font-family:SimHei;font-size:1.2em;color:red;}", "text/css");

                case "theme2":

                    return Content("body{font-family:KaiTi;font-size:2.2em;color:green;}", "text/css");

                default:

                    return Content("body{font-family:SimSong;font-size:3.2em;color:blue;}", "text/css");
            }
        }

        public IActionResult Image(string id)
        {
            if (string.IsNullOrEmpty(id)) return View();
            string path = ImagePath(id);
            if (!System.IO.File.Exists(path)) return NotFound();
            return PhysicalFile(path, "image/png");
        }

        public IActionResult Down(string id)
        {
            string path = ImagePath(id);
            if (!System.IO.File.Exists(path)) return NotFound();

            string name = Path.GetFileName(path);

            return PhysicalFile(path, "image/png", name);
        }

        public IActionResult Error()
        {
            return View();
        }

        private string ImagePath(string id)
        {
            return Path.Combine(_env.WebRootPath, "Images", Path.GetFileName(id ?? "") + ".png");
        }
    }
}

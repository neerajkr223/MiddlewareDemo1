using Microsoft.AspNetCore.Mvc;

namespace SessionDemo1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}

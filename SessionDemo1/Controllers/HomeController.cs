using Microsoft.AspNetCore.Mvc;
using SessionDemo1.Models;
using System.Diagnostics;

namespace SessionDemo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string? name)
        {
            if (name != null)
            {
                HttpContext.Session.SetString("Name", name);
                return RedirectToAction("Success");
            }
            return View();
        }

        public IActionResult Success()
        {
            ViewData["Name"]=HttpContext.Session.GetString("Name");
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewData["Name"] = HttpContext.Session.GetString("Name");
            return View(); 
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

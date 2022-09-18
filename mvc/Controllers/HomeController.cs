using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag, ViewData, TempData, Model

            ViewBag.Name = "Bilal";
            ViewData["Name"] = "Elif";
            TempData["Name"] = "Mehmet";

            return View();
        }

        public IActionResult Index2(int id)
        {
            return View();
        }
    }
}

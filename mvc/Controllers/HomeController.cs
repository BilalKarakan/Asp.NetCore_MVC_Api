using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag, ViewData, TempData, Model

            /*
            Dictionary<string, object > dictionary = new();
            var list = dictionary.Values;
            */

            var id = (string)RouteData.Values["id"];    

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

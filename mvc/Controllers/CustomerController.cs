using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new()
            {
                FirstName = "Bilal",
                LastName = "Karakan",
                Age = 23
            };
            return View("example",customer);
        }
    }
}

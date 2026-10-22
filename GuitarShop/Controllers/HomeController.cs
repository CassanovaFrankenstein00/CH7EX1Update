using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("contact-us")]
        public IActionResult ContactUs()
        {
            var contact = new Dictionary<string, string> { { "Phone", "555-123-4567" }, { "Email", "info@myguitarshop.com" }, { "Address", "123 Main St, Anytown, USA" }, {"Fax", "555-987-6543" } };
            return View(contact);
        }
    }    
}

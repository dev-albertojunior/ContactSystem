using Microsoft.AspNetCore.Mvc;

namespace ContactSystem.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateContact()
        {
            return View();
        }
        public IActionResult EditContact()
        {
            return View();
        }
        public IActionResult DeleteContact()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace NOA_Library.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutUs()
        {

            return View();
        }
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NOA_Library.Controllers
{
    public class ProfileController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}

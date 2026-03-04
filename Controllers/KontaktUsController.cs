using Microsoft.AspNetCore.Mvc;
using NOA_Library.Models;

namespace NOA_Library.Controllers
{
    public class KontaktUsController : Controller
    {

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult Kontakto()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Kontakto(Kontakt contactUs)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }


            return View(contactUs);
        }
    }
}
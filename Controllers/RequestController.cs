using Microsoft.AspNetCore.Mvc;
using NOA_Library.Models;

namespace NOA_Library.Controllers
{
    public class RequestController : Controller
    {

        public IActionResult Requesti()
        {
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Requesti(Request request)
        {
            if (ModelState.IsValid)
            {

                TempData["SuccessMessage"] = "Your Request Was Sent Successfully!";


                return RedirectToAction("Requesti");
            }


            return View(request);
        }
    }
}
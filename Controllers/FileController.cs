using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace NOA_Library.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /File/Download/{fileName}
        [HttpGet]
        public IActionResult Download(string fileName)
        {
            // Kontrolloni nëse fileName është null ose i zbrazët
            if (string.IsNullOrEmpty(fileName))
            {
                return BadRequest("Emri i skedarit nuk mund të jetë null ose bosh.");
            }

            // Definoni rrugën deri te skedari brenda wwwroot/images
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

            // Kontrolloni nëse skedari ekziston
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound(); // Ktheje 404 nëse skedari nuk ekziston
            }

            // Merrni llojin e përmbajtjes së skedarit
            var contentType = "application/octet-stream"; // Lloji i përmbajtjes së paracaktuar
            var fileExtension = Path.GetExtension(fileName).ToLowerInvariant();

            // Vendosni llojin e përmbajtjes bazuar në shtrirjen e skedarit (opsional)
            switch (fileExtension)
            {
                case ".pdf":
                    contentType = "application/pdf";
                    break;
                case ".jpg":
                case ".jpeg":
                    contentType = "image/jpeg";
                    break;
                case ".png":
                    contentType = "image/png";
                    break;
                case ".txt":
                    contentType = "text/plain";
                    break;
                    // Shtoni më shumë raste sipas nevojës
            }

            // Ktheje skedarin për shkarkim
            return PhysicalFile(filePath, contentType, fileName);
        }
    }
}


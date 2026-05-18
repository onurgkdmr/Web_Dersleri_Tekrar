using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            // Razor => HTML sayfasında C# kodları yazmak için kullanılan bir teknolojidir.
            return View();
        }

        public IActionResult Menu()
        {
            for (int i = 0; i < 10; i++)
            {

            }

            if (DateTime.Now.Hour < 12)
            {
                ViewBag.mesaj = "Günaydın";
            }
            int x = 90;
            int[] sayilar = new int[10];

            return View();
        }
    }
}

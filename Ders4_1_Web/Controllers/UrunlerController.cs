using Microsoft.AspNetCore.Mvc;

namespace Ders4_1_Web.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Ders1_1_MVC.Models;

namespace Ders1_1_MVC.Controllers
{
    public class UrunlerController : Controller
    {
        [HttpGet] // Sayfa ilk yüklendiğinde çalışacak olan method
        public IActionResult Index() // Bu methodun görüntüsünü görmek için projeyi çalıştırdıktan sonra           http://localhost:.../urunler/Index yazmamız gerekir.
        {
            return View();
        }

        [HttpPost] // Açılan index (View) html sayfasında bir form oluşturup bu form altında yer alan input'ları doldurup gönderdiğimizde çalışacak olan method. Tetiklenmesi için formun methodunun "post" olması gerekir ve form action'ının da url'sine yönlendirilmesi gerekir. Yani form action'ı action = "Urunler/Index" şeklinde olmalıdır. Asıl tetiklenmeyi form altında yer alan submit butonuna basarak yapacağız. Bu yazılanlar Urunler/Index view sayfasında mevcuttur. Oraya bakarak daha iyi anlayabilirsiniz.
        public IActionResult Index(string isim, string soyisim)
        {
            return View();
        }

        // Eğer bir method başında HttpGet, HttpPost, HttpPull, HttpPut, HttpDelete gibi yapılar yazılmadıysa varsayılan olarak HttpGet kabul edilir.
        public IActionResult UrunList()
        {
            UrunModel urunModel=new UrunModel();
            return View(urunModel);
        }

        [HttpPost]

        public IActionResult UrunList(UrunModel urunModel)
        {
            if (urunModel.Adi==null)
            {
                // Sayfalar arasında data alışverişi için 3 yapı kullanılır:
                /*
                 1) ViewBag.degiskenAdi
                 2) ViewData["degiskenAdi"]
                 3) TempData["degiskenAdi"]
                 */
                ViewBag.Hata = "Ürün adı boş geçilemez";
                
                // ViewBag'i HTML sayfasında göstermek için Razor teknolojisi olan @ işaretine ihtiyaç duyulur.
               
                return View(urunModel);
            }
            TempData["eklendi"] = "Ürün kayıt başarılı";
            return View();
        }
    }
}

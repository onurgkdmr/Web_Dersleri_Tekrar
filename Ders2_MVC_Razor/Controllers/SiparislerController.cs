using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class SiparislerController : Controller
    {
        public IActionResult List()
        {
            //4 tane sipariş olacak şekilde Id,sipariş ürünün,sipariş tarihi,sipariş veren müşteri adı soyadı, sipariş tutarı, sipariş kargo maliyeti, sipariş teslim edildimi (true-teslim edildi, false-teslim edilmedi) gibi bilgileri içeren siparişler tanımlayarak list yapısı ile siparişler view sayfasında table şeklinde gösteriniz
            //Eğer sipariş tesli edildi mi true ise liste içerisinde teslim edildi olarak, false ise teslim edilmedi olarak gösteriniz->HTML içinde razor teknolojisi kullanarak yapınız
            //Kargo maliyeti 0 ise müşteri kargo maliyeti kısmına ücretsiz yazacak şekilde gösteriniz->HTML içinde razor teknolojisi kullanarak yapınız
            //Siparişler için model oluşturunuz.

            return View();
        }
    }
}

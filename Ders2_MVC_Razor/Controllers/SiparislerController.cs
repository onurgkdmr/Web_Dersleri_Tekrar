using Ders2_MVC_Razor.Models;
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

            List<SiparisListesiModel> siparisListesi = new List<SiparisListesiModel>();
            
            SiparisListesiModel siparisEdilenUrun = new SiparisListesiModel();

            siparisEdilenUrun.Id = 1;
            siparisEdilenUrun.UrunAdi = "Webcam";
            siparisEdilenUrun.SiparisTarihi = new DateTime(2026, 1, 10);
            siparisEdilenUrun.MusteriAdiSoyadi = "Serhat Demir";
            siparisEdilenUrun.Fiyat = 1249.99;
            siparisEdilenUrun.KargoMaliyeti = 80;
            siparisEdilenUrun.TeslimEdildiMi = true;

            siparisListesi.Add(siparisEdilenUrun);

            siparisEdilenUrun = new SiparisListesiModel();
            siparisEdilenUrun.Id = 2;
            siparisEdilenUrun.UrunAdi = "Powerbank";
            siparisEdilenUrun.SiparisTarihi = new DateTime(2026, 2, 10);
            siparisEdilenUrun.MusteriAdiSoyadi = "Mehmet Akın";
            siparisEdilenUrun.Fiyat = 1449.99;
            siparisEdilenUrun.KargoMaliyeti = 0;
            siparisEdilenUrun.TeslimEdildiMi = true;

            siparisListesi.Add(siparisEdilenUrun);

            siparisEdilenUrun = new SiparisListesiModel();
            siparisEdilenUrun.Id = 3;
            siparisEdilenUrun.UrunAdi = "Akıllı Saat";
            siparisEdilenUrun.SiparisTarihi = new DateTime(2026, 3, 10);
            siparisEdilenUrun.MusteriAdiSoyadi = "Hande Vural";
            siparisEdilenUrun.Fiyat = 6549.99;
            siparisEdilenUrun.KargoMaliyeti = 100;
            siparisEdilenUrun.TeslimEdildiMi = false;

            siparisListesi.Add(siparisEdilenUrun);

            siparisEdilenUrun = new SiparisListesiModel();
            siparisEdilenUrun.Id = 4;
            siparisEdilenUrun.UrunAdi = "AirPods";
            siparisEdilenUrun.SiparisTarihi = new DateTime(2026, 4, 10);
            siparisEdilenUrun.MusteriAdiSoyadi = "Yavuz Kara";
            siparisEdilenUrun.Fiyat = 8999.99;
            siparisEdilenUrun.KargoMaliyeti = 120;
            siparisEdilenUrun.TeslimEdildiMi = true;

            siparisListesi.Add(siparisEdilenUrun);

            return View(siparisListesi);
        }
    }
}

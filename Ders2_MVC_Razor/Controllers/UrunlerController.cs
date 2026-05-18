using Ders2_MVC_Razor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult UrunListesi()
        {
            //Ürünler için Id, adı, fiyatı, stok değeri, alış tarihi , tedarikçi adı-soyadı gibi bilgileri içeren 6 tane teknolojik ürün tanımlayarak list yapısı ile ürün view sayfasında table şeklinde gösteriniz.
            //Ürün için Model olmalı.
            //Klavye, mouse, monitör, laptop, telefon, tablet, süpürge makinası, akıllı mutfak robotu,... gibi ürünler olabilir.
            List<UrunListesiModel> urunListesi = new List<UrunListesiModel>();

            UrunListesiModel eklenecekUrun = new UrunListesiModel();

            eklenecekUrun.Id = 1;
            eklenecekUrun.Adi = "Logitech Klavye";
            eklenecekUrun.Fiyat = 299.99;
            eklenecekUrun.Stok = 50;
            eklenecekUrun.AlisTarihi = new DateTime(2025, 1, 15);
            eklenecekUrun.TedarikciAdiSoyadi = "Ahmet Yılmaz";

            urunListesi.Add(eklenecekUrun);

            eklenecekUrun = new UrunListesiModel();
            eklenecekUrun.Id = 2;
            eklenecekUrun.Adi = "Dell Monitör";
            eklenecekUrun.Stok = 30;
            eklenecekUrun.Fiyat = 1499.99;
            eklenecekUrun.AlisTarihi = new DateTime(2025, 2, 10);
            eklenecekUrun.TedarikciAdiSoyadi = "Mehmet Demir";

            urunListesi.Add(eklenecekUrun);

            eklenecekUrun = new UrunListesiModel();
            eklenecekUrun.Id = 3;
            eklenecekUrun.Adi = "Dell Kasa";
            eklenecekUrun.Stok = 5;
            eklenecekUrun.Fiyat = 25000;
            eklenecekUrun.AlisTarihi = new DateTime(2025, 2, 10);
            eklenecekUrun.TedarikciAdiSoyadi = "Selime Sayan";

            urunListesi.Add(eklenecekUrun);



            return View(urunListesi);
        }
    }
}

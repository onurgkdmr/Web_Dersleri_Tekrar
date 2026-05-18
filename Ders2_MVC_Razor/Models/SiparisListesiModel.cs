namespace Ders2_MVC_Razor.Models
{
    public class SiparisListesiModel
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public double Fiyat { get; set; }
        public double KargoMaliyeti { get; set; }
        public bool TeslimEdildiMi { get; set; }
    }
}

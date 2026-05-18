namespace Ders2_MVC_Razor.Models
{
    public class UrunListesiModel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public DateTime AlisTarihi { get; set; }
        public string TedarikciAdiSoyadi { get; set; }
    }
}

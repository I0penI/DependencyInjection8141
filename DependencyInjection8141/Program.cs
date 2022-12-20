using System.Xml.Linq;

namespace DependencyInjection8141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif sinif = new Sinif()
            {
                Kodu = "8141",
                Kurs = "Bilge Adam"
            };
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = "Ali",
                SoyAdi = "Arslan",
                Sinif = sinif,
            };
            Console.WriteLine($"Adı: {ogrenci.Adi} \n" +
                $"Soyadı: {ogrenci.SoyAdi} \n" +
                $"Kursu: {ogrenci.Sinif.Kurs} \n" +
                $"Kodu: {ogrenci.Sinif.Kodu}");

            Ogrenci yeniOgrenci = new Ogrenci()
            {
                Adi = "Emir",
                SoyAdi = "Bakar",
                Sinif = new Sinif()
                {
                    Kodu = "8438",
                    Kurs = "Bilge Adam"
                }

            };
            Console.WriteLine($"Adı: {yeniOgrenci.Adi} \n" +
                $"Soyadı: {yeniOgrenci.SoyAdi} \n" +
                $"Kursu: {yeniOgrenci.Sinif.Kurs} \n" +
                $"Kodu: {yeniOgrenci.Sinif.Kodu}");
        }
    }
    class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public Sinif Sinif { get; set; } // Has a relationship
    }
    class Sinif
    {
        public string Kodu { get; set; }
        public string Kurs { get; set; }
    }
}
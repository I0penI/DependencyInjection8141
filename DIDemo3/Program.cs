namespace DIDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi hesapMakinesi = new GelismisHesapMakinesi();
            HesapServis servis = new HesapServis(hesapMakinesi);
            Console.WriteLine("Toplam: " + servis.HesapMakinesi.Topla(1448, 888, 999));
            Console.WriteLine("Bölüm: " + servis.HesapMakinesi.Bol(1448, 888 ));
            Console.WriteLine("Kalan: " + ((GelismisHesapMakinesi)servis.HesapMakinesi).Kalan(88,66));
        }
    }
    abstract class HesapMakinesi
    {
        public virtual double Topla(params double[] sayilar)
        {
            return sayilar.Sum();
        }
      
        public virtual double Carp(params double[] sayilar)
        {
            double sonuc = 1;
            foreach (double sayi in sayilar)
            {
                sonuc *= sayi;
            }
            return sonuc;
        }
        public virtual double Cikar(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }
        public virtual double Bol(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }

    }
    class IlkelHesapMakinesi : HesapMakinesi
    {

    }
    class GelismisHesapMakinesi : HesapMakinesi
    {
        public double Kalan(double sayi1, double sayi2)
        {
            return sayi1 % sayi2;
        }
        public double Us(double taban, double us)
        {
            return Math.Pow(taban, us);

        }
    }
    class HesapServis
    {
        public HesapMakinesi HesapMakinesi { get; set; }

        public HesapServis(HesapMakinesi hesapMakinesi)
        {
            HesapMakinesi = hesapMakinesi;
        }

       
    }
}
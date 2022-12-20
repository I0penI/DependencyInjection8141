namespace DependencyInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurucuBase surucu = new Surucu() { Adi = "Ali", Soyadi = "Arslan", EhliyetNo = "123789541" };
            SurucuBase yeniSurucu = new Surucu { Adi = "Burak" };
            Araba araba = new Araba(surucu);
            araba.Marka = "GTR35";
            araba.Sur();
            
            
        }
    }
    class Araba
    {
        public string Marka { get; set; }
        private readonly SurucuBase _surucu;

        public Araba(SurucuBase surucu)
        {
            _surucu = surucu;
        }


        public void Sur()
        {
            Console.WriteLine($"{Marka} markalı araba {_surucu.Adi} {_surucu.Soyadi} tarafından sürülüyor.");
        }
     
    }
    abstract class SurucuBase
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string EhliyetNo { get; set; }
    }
    class Surucu : SurucuBase
    {

    }
}
namespace DIDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new BenzinliMotor()
            {
                BeygirGucu = 125,
                Hacmi = 1600,
                
            };
            Arac arac = new Arac(motor)
            {
                Marka = "Honda Civic"
            };
            arac.BilgileriGetir();
        }
    }
    class Arac
    {
        public string Marka { get; set; }
        private readonly Motor _motor;

        public Arac(Motor motor)
        {
            _motor = motor;
        }

        public void BilgileriGetir()
        {
            Console.WriteLine("Marka: " + Marka + ", Motor Hacmi: " + _motor.Hacmi + ", Beygir Gücü: " + _motor.BeygirGucu + ", Yakıt Tipi: " + _motor.YakitTipi);
        }
    }
    
    abstract class Motor // Base
    {
        public short BeygirGucu { get; set; }
        public short Hacmi  { get; set; }
        public virtual string YakitTipi { get; } 



    }
    class BenzinliMotor : Motor
    {
        //1. yöntem
        //public override string YakitTipi
        //{
        //    get
        //    {
        //        return "Benzin";
        //    }
        //}
        //2. yöntem
        public override string YakitTipi => "Benzin";  // get;
    }
    class DizelMotor : Motor
    {
        public override string YakitTipi => "Dizel"; // get;
    }
}
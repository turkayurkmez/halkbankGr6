namespace Inheritance
{
    public class Yemek
    {
        public Yemek()
        {
            Sure = 40;
        }
        public int Sure { get; set; }
        public List<string> Malzemeler { get; set; }

        public double Fiyat { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name}, {Sure} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, pilav ile sunuldu");
        }
    }

    public class Corba : Yemek
    {
        public Corba()
        {
            Sure = 25;
        }
        public bool LimonOlsunMu { get; set; }
        public bool SogukMu { get; set; }
        public string Baharatlar { get; set; }
    }

    public class DomatesCorbasi : Corba
    {
        public bool KasarOlsunMu { get; set; }


    }

    public class Pilav : Yemek
    {

    }

    public class EtYemegi : Yemek { }

    public class Kebap : EtYemegi
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yanında bilmemneyle sunuldu....");
        }
    }

    public class Baklava : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, dondurma ile sunuldu");
        }
    }

}

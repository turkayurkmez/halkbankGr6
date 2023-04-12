namespace AbstractionAndInterface
{
    public class Insan
    {
        public void Giy(IKiyafet kiyafet)
        {

        }
    }
    public interface IKiyafet
    {

    }

    public abstract class IcGiyim : IKiyafet
    {

    }
    public abstract class AltGiyim : IKiyafet
    {

    }
    public abstract class UstGiyim
    {

    }
    public class Kazak : UstGiyim
    {

    }
    public class KirmiziKazak : Kazak
    {

    }


}

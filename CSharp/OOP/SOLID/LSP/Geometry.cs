namespace LSP
{
    //Barbara Liskov's Substution Principle
    //Liskov diyor ki: Eğer bir Square, Rectangle'dan miras alıyorsa; o halde bir fonksiyon Rectangle döndürüyorsa, bu rahatlıkla, herhangi bir değişikllik yapmadan Square'da döndürebilmeli...
    public class Geometry
    {
        public IAreaCalcutable GetAreaCalcutable(int unit1, int? unit2 = null)
        {

            if (unit2 == null)
            {
                return new Square { EdgeLength = unit1 };
            }
            //bir biçimde...
            else
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }
        }
    }

    public interface IAreaCalcutable
    {
        int GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IAreaCalcutable
    {
        public int EdgeLength { get; set; }
        public int GetArea()
        {
            return EdgeLength * EdgeLength;
        }

    }
}

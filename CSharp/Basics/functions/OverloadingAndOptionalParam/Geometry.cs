namespace OverloadingAndOptionalParam
{
    public class Geometry
    {
        /// <summary>
        /// Kare veya Daire şekillerinin alanlarını hesaplar
        /// </summary>
        /// <param name="unit1">Daire için yarı çap, kare içinm kenar uzunluğunu giriniz.</param>
        /// <param name="symbol">daire veya kare kelimesini girin.</param>
        /// <returns></returns>
        public double CalculateArea(double unit1, string symbol)
        {
            switch (symbol)
            {
                case "kare":
                    return Math.Pow(unit1, 2);
                case "daire":
                    return Math.Pow(unit1, 2) * Math.PI;
                default:
                    return 0;
            }

        }
        /// <summary>
        /// Üçgen veya Dikdörtgen şekillerinin alanlarını hesaplar
        /// </summary>
        /// <param name="unit1">Üçgen için alt kenar, dikdörtgen için en uzunluğunu giriniz.</param>
        /// <param name="unit2"></param>
        /// <param name="symbol">üçgen veya dikdörtgen kelimesini girin.</param>
        /// <returns></returns>
        public double CalculateArea(double unit1, double unit2, string symbol)
        {
            switch (symbol)
            {
                case "üçgen":
                    return (unit1 * unit2) / 2;
                case "dikdörtgen":
                    return unit1 * unit2;
                default:
                    return 0;
            }
        }

        public double AlternativeArea(double unit1, double unit2 = 0, string symbol = "kare")
        {
            switch (symbol)
            {
                case "kare":
                    return Math.Pow(unit1, 2);
                case "daire":
                    return Math.Pow(unit1, 2) * Math.PI;
                case "üçgen":
                    return (unit1 * unit2) / 2;
                case "dikdörtgen":
                    return unit1 * unit2;
                default:
                    return 0;
            }

        }




    }
}

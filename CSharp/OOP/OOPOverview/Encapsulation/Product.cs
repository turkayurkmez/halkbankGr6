namespace Encapsulation
{
    public class Product
    {
        private decimal price;

        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Fiyat değeri negatif olamaz!");
            }
            this.price = value;
        }

        public decimal GetPrice()
        {
            return price;
        }

        //Her product'un ............. vardır.
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public double? Rating { get; set; }

        public int Stock { get; private set; }

        public void ChangeStock(int newStock)
        {
            Stock = newStock;
        }



        //Eğer; private set ifadesi yoksa, o özelliğe sadece constructor içinde değer atayabilirsiniz!
        public bool IsAvailable { get; }

        public Product()
        {
            IsAvailable = Stock > 0;
        }
    }
}

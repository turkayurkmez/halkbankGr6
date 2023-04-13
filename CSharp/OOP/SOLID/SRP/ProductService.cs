namespace SRP
{
    class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            DbProcess process = new DbProcess();
            return process.Add(name, price);
        }

        public void SendMailToSupplier(string supplier)
        {

        }
    }
}

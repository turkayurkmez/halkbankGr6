namespace SRP
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * SRP: Single Responsibility Principle
         * Bir nesne içinde değişiklik yapmanız için birden fazla sebebiniz varsa; ilkeyi ihlal ediyorsunuz.
         * Form1 bir insan olsaydı, sorumluluğunu nasıl anlatırdı?
         */
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            var name = textBoxProductName.Text;
            var price = Convert.ToDecimal(textBoxPrice.Text);
            var affectedRows = productService.AddProduct(name, price);
            string message = affectedRows > 0 ? "Kayıt başarılı" : "Kayıt yapılamadı";
            MessageBox.Show(message);

        }
    }
}
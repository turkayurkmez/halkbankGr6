namespace createAndUseEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                labelState.Text = $"Shift ile birlikte {e.KeyCode} tetiklendi";

            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            categoryService.CategoryCreated += CategoryService_CategoryCreated;

            categoryService.AddCategory(new Category { Id = 1, Name = "Giyim" });
        }

        private void CategoryService_CategoryCreated(object sender, CategoryEventArgs e)
        {
            MessageBox.Show($"{e.Category.Name} kategorisi, {e.CreatedDate} tarihinde {e.Owner} kişisi tarafından eklendi");
        }
    }
}
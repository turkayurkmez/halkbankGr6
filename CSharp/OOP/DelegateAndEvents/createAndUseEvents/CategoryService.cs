namespace createAndUseEvents
{

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class CategoryEventArgs : EventArgs
    {
        public Category Category { get; set; }
        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
    }


    public class CategoryService
    {
        public delegate void CategoryCreatedEventHandler(object sender, CategoryEventArgs e);
        public event CategoryCreatedEventHandler CategoryCreated;
        public void AddCategory(Category category)
        {
            //farz edin ki db'ye ekledik!
            if (CategoryCreated != null)
            {
                CategoryEventArgs args = new CategoryEventArgs() { Category = category, CreatedDate = DateTime.Now, Owner = "Türkay" };
                CategoryCreated(this, args);
            }
        }
    }
}

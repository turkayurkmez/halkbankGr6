namespace eshop.Entities
{
    //Unutma: IEntity interface'inin tek amacı tipi işaretlemek.
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property:
        public IList<Product> Products { get; set; }
    }
}

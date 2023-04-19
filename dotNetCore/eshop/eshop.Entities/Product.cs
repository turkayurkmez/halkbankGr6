using System.ComponentModel.DataAnnotations;

namespace eshop.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş bırakmayınız....")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public double? Rating { get; set; }
        public double? DiscountRate { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }



    }
}

using System.ComponentModel.DataAnnotations;

namespace eshop.Application.DTOs.Requests
{
    public class CreateProductRequest
    {
        [Required(ErrorMessage = "Boş bırakmayınız....")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public double? Rating { get; set; }
        public double? DiscountRate { get; set; }
        public string? ImageUrl { get; set; }
        public int? CategoryId { get; set; }

    }
}

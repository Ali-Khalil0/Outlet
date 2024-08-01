using System.ComponentModel.DataAnnotations;

namespace KhalilsOutlet.Models
{
    public class ProductDto
    {
        [Required,MaxLength(250)]
        public string Name { get; set; } = "";
        [Required,MaxLength(150)]
        public string Brand { get; set; } = "";
        [Required,MaxLength(150)]
        public string Category { get; set; } = "";
        [Required]
        public decimal price { get; set; }
        [Required]  
        public string Description { get; set; } = "";
        public IFormFile? ImageFile { get; set; }
    }
}

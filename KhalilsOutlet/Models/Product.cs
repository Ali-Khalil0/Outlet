using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KhalilsOutlet.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; } = "";
        [MaxLength(150)]
        public string Brand { get; set; } = "";
        [MaxLength(150)]
        public string Category { get; set; } = "";
        [Precision(16, 2)]
        public decimal price { get; set; }

        public string Description { get; set; } = "";
        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }

    }
}

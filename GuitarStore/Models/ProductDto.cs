using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GuitarStore.Models
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; } = "";

        [Required] 
        public string Brand { get; set; } = "";

        [Required]
        public string Category { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Contact { get; set; } = "";

        public IFormFile? ImageFile { get; set; }
    }
}

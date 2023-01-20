using System.ComponentModel.DataAnnotations;

namespace BabyOnLineStore.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string? Name { get; set; }
        public string? ProductId { get; set; }
        public string? Categories { get; set; }

        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public string? Type { get; set; }
        public string? ProductDescription { get; set; }
        public string? Brand { get; set; }
        public string? Image { get; set; }
        public DateTime Created { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BabyOnLineStore.Models
{
    public class Products
    {

        public int Id { get; set; }
        [Required]
        public string? ItemName { get; set; }
        [Required]
        public string? Categories { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? ProductDescription { get; set; }

        public string? Image { get; set; }
        [Required]
        public DateTime DataCreated { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductTypes? ProductTypes { get; set; }



    }
}

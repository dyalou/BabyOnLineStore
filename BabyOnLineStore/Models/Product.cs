using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyOnLineStore.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string? ItemName { get; set; }

        public string? Categories { get; set; }

        public double Price { get; set; }

        public string? Type { get; set; }

        public string? ProductDescription { get; set; }

        public string? Image { get; set; }

        public DateTime DataCreated { get; set; }
        [ForeignKey("ProductTypedId")]
        public ProductTypes ProductType { get; set; }
    }
}

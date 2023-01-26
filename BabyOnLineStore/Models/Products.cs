using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BabyOnLineStore.Models
{
    public class Products
    {

        public int Id { get; set; }

        public string? ItemName { get; set; }

        public string? Categories { get; set; }

        public double Price { get; set; }

        public string? Type { get; set; }

        public string? ProductDescription { get; set; }

        public string? Image { get; set; }

        public DateTime DataCreated { get; set; }

        [Display(Name = "Product Type")]

        public int ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public virtual ProductTypes ProductTypes { get; set; }

    }
}

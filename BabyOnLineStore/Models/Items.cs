using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyOnLineStore.Models
{
    public class Items
    {

        public int Id { get; set; }
        [Required]
        public string? ItemName { get; set; }

        public string? Categories { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Type { get; set; }
        public string? ProductDescription { get; set; }
        public string? Image { get; set; }
        public DateTime DataCreated { get; set; }
        [ForeignKey("ProductTypedId")]
        public ItemsList ProductTypes { get; set; }
    }
}

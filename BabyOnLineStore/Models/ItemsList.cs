using System.ComponentModel.DataAnnotations;

namespace BabyOnLineStore.Models
{
    public class ItemsList
    {
        public int Id { get; set; }
        //[Required]
        //[Display(Name = "Product Type")]
        public string ProductType { get; set; }

    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Item
    {
        [Key]
        [RegularExpression(@"^[A-Z''-'\s]{3,3}[\d]{3,3}$",
         ErrorMessage = "Product code format is strictly 'AAA999'")]
        public string Code { get; set; }
        public string Description { get; set; }
        
        [DisplayName("Price (€)")]
        public double Price { get; set; }
    }
}

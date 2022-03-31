using System.ComponentModel;

namespace ShoppingCart.Models
{
    public class Item
    {
        public string Code { get; set; }
        public string Description { get; set; }
        
        [DisplayName("Price (€)")]
        public double Price { get; set; }
    }
}

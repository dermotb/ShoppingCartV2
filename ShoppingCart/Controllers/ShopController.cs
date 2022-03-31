using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ShopController : Controller
    {
        private static List<Item> items
            = new List<Item>() { 
            new Item { Code="123", Description="Cuddly Toy", Price=12.50},
            new Item { Code="AT123", Description="Lego Batman", Price=25.75},
            new Item { Code="XYZ555", Description="Gardening Set", Price=89.99},
            new Item { Code="VV23", Description="Bicycle", Price=850.99} 
            };

        
        private static Cart cart = new Cart();

        public IActionResult Index()
        {
            return View(items);
        }
    }
}

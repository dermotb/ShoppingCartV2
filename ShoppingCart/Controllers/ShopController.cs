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
        private static int instanceCount = 0;

        public ShopController()
        {
            instanceCount++;
        }

        public IActionResult Index()
        {
            ViewBag.TotalPrice = cart.CalculateTotalPrice();
            ViewBag.LastAdded = instanceCount;
            return View(items);
        }

        public ActionResult AddToCart(string code)
        {
            try
            {
                foreach(Item itm in items)
                {
                    if (itm.Code == code)
                    {
                        cart.AddItem(itm);
                        break;
                    }
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GoToHome()
        {
            return RedirectToAction("Index", "Home");
        }
        
    }
}

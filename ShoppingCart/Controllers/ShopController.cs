using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ShopController : Controller
    {/*
        private static List<Item> items
            = new List<Item>() { 
            new Item { Code="123", Description="Cuddly Toy", Price=12.50},
            new Item { Code="AT123", Description="Lego Batman", Price=25.75},
            new Item { Code="XYZ555", Description="Gardening Set", Price=89.99},
            new Item { Code="VV23", Description="Bicycle", Price=850.99} 
            };
        */
        
        private static Cart cart = new Cart();

        private readonly ItemsContext _context;

        public ShopController(ItemsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        public IActionResult Index()
        {
            ViewBag.TotalPrice = cart.CalculateTotalPrice();
            return View(_context.Item);
        }

        public ActionResult AddToCart(string code)
        {
            try
            {
                foreach (Item itm in _context.Item)
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

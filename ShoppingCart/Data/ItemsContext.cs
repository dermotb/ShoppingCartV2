using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext (DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<ShoppingCart.Models.Item> Item { get; set; }
    }
}

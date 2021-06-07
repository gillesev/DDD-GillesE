using Microsoft.EntityFrameworkCore;

namespace DDDTraining.ShoppingCart.Data
{
    /// <summary>
    /// This is the Unit of Work EF context responsible for persisting an in-progress customer's shopping cart.
    /// </summary>
    public class ShoppingCartUoW: DbContext
    {
        /// <summary>
        /// Injects the context options (set during startup)
        /// </summary>
        public ShoppingCartUoW(DbContextOptions<ShoppingCartUoW> options): base(options)
        {
        }

        /// <summary>
        /// Sets of shopping carts
        /// </summary>
        public DbSet<ShoppingCartEntity> Carts { get; set; }

        /// <summary>
        /// Sets of cart items
        /// </summary>
        public DbSet<ShoppingCartItemEntity> Items { get; set; }

        /// <summary>
        /// Sets of Retail Sales Pos Logs
        /// </summary>
        public DbSet<RetailPosLogEntity> RetailPosLogs {get; set;}
    }
}
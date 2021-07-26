using System.Collections.Generic;

namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents an item added to a shopping cart
    /// </summary>
    public class ShoppingCartItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int ItemNumber { get; set; }

        /// <summary>
        /// Represents the product added to the cart
        /// </summary>
        public ProductItem Product { get; set; }

        /// <summary>
        /// Product base Price (before any promotion is applied) evaluated 
        /// at the time the order is placed.
        /// </summary>
        /// <example>
        /// 12.99
        /// </example>
        public decimal BasePrice { get; set; }        

        /// <summary>
        /// Quantity purchased
        /// </summary>
        /// <example>
        /// 5.99
        /// </example>
        public int Quantity { get; set; }
    }
}
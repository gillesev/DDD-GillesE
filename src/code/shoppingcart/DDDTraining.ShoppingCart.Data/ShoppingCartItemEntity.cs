using System.Collections.Generic;

namespace DDDTraining.ShoppingCart.Data
{
    /// <summary>
    /// Represents an item persisted into a shopping cart
    /// </summary>
    public class ShoppingCartItemEntity
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int ItemNumber { get; set; }

        /// <summary>
        /// Item's Product SKU
        /// </summary>
        public int SKU { get; set; }

        /// <summary>
        /// Quantity purchased
        /// </summary>
        /// <example>
        /// 5
        /// </example>
        public int Quantity { get; set; }
    }
}
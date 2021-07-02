using System.ComponentModel.DataAnnotations;

namespace DDDTraining.Transactions.APIs
{
    /// <summary>
    /// Represents an adjustment made to the shopping cart for a given line # or SKU item.
    /// </summary>
    /// <example>
    /// Add 3 bottles of Acetominophen
    /// </example>
    public class CartItemAdjustmentDTO
    {
        [Required]
        /// <summary>
        /// (REQUIRED) Represents a unique increment to distinguish 2 lines for the same product SKU
        /// Responsibility of front end client application for allocation this line #.
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int ItemNumber { get; set; }


        [Required]
        /// <summary>
        /// (REQUIRED) Represents the product SKU added/removed to the cart
        /// </summary>
        public int SKU { get; set; }

        /// <summary>
        /// (REQUIRED) Indicates if we need to remove this line from the cart.
        /// </summary>
        public bool Remove { get; set; }

        /// <summary>
        /// Represents the new quantity for this product SKU
        /// May be NULL if Remove is TRUE.
        /// </summary>
        /// <example>
        /// 5
        /// </example>
        public int? Quantity { get; set; }
    }
}
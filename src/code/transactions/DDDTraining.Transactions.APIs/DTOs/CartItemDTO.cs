namespace DDDTraining.Transactions.APIs
{
    /// <summary>
    /// Represents a shopping cart item exposed to the outside world
    /// </summary>
    public class CartItemDTO
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int ItemNumber { get; set; }

        /// <summary>
        /// Represents the Retailer Merchandise SKU unique identifer (not serial #)
        /// </summary>
        /// <example>
        /// 976541
        /// </example>
        public int SKU { get; set; }

        /// <summary>
        /// Short Description to be rendered on cart on-line or in email receipt
        /// </summary>
        /// <example>
        /// Baby Monitor Samsung
        /// </example>
        public string ProductShortDescription { get; set; }

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

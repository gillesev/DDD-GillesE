namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Represent a Retail Product/Service that can be purchased online.
    /// </summary>
    public class ProductItem
    {
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
    }
}
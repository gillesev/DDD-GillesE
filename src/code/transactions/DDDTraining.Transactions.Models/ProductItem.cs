using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTraining.Transactions.Models
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

        /// <summary>
        /// Product base Price (before any promotion is applied) evaluated 
        /// at the time the product is added in the cart.
        /// Single Currency USD.
        /// </summary>
        /// <example>
        /// 12.99
        /// </example>
        public decimal BasePrice { get; set; }
    }
}

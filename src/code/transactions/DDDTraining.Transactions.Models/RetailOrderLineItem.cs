using System.Collections.Generic;

namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents an order line item.
    /// </summary>
    /// <example>
    /// 3 bottles of Acetominophen
    /// </example>
    public class RetailOrderLineItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int LineNumber { get; set; }

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
        /// 5
        /// </example>
        public int Quantity { get; set; }

        /// <summary>
        /// List of discounts applied to this order line item
        /// </summary>
        public IList<RetailOrderLineItemDiscount> Discounts {get; set;}

        /// <summary>
        /// List of taxes applied to this order line item
        /// </summary>
        public IList<RetailOrderLineItemTax> Taxes {get; set;}       
    }
}
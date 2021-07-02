using DDDTraining.ECommerce.SharedModels;
using System.Collections.Generic;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents an order line item.
    /// </summary>
    /// <example>
    /// 3 bottles of Acetominophen
    /// </example>
    public class OMSOrderLineItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int LineNumber { get; set; }

        /// <summary>
        /// Represents the product SKU with its shipping/handling properties
        /// </summary>
        public OMSProductItem Item { get; set; }

        /// <summary>
        /// Quantity purchased
        /// </summary>
        /// <example>
        /// 5
        /// </example>
        public int Quantity { get; set; } 

        /// <summary>
        /// Postal Address where this specific item needs to be shipped
        /// </summary>
        /// <example>
        /// 880 Eden Court, San Fransisco CA 94016 - USA
        /// </example>        
        public PostalAddress ShippingAddress { get; set; } 

        /// <summary>
        /// List of shipping requirements sold to the customer.
        /// <summary>
        public IList<OMSShippingRequirement> ShippingRequirements { get; set; }         
    }
}
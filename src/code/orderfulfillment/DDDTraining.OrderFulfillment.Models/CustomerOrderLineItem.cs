using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a Customer order line item.
    /// </summary>
    /// <example>
    /// 3 bottles of Acetominophen
    /// </example>
    public class CustomerOrderLineItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int LineNumber { get; set; }

        /// <summary>
        /// Represents the product SKU
        /// </summary>
        /// <example>
        /// 32643263
        /// </example>        
        public int SKU { get; set; }

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
        /// Date/Time in UTC format when the item is due to be delivered at its destination address.
        /// </summary>
        /// <example>
        /// 07/01/2021 12:00 PM UTC.
        /// </example>
        public DateTime DeliveryDueDateTimeUTC { get; set; }
    }
}
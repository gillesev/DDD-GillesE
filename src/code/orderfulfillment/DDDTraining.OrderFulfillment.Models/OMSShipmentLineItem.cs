using DDDTraining.ECommerce.SharedModels;
using System.Collections.Generic;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a line item in a shipment.
    /// </summary>
    /// <example>
    /// 3 bottles of Acetominophen
    /// </example>
    public class OMSShipmentLineItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 shipment lines
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int ShipmentLineNumber { get; set; }

        /// <summary>
        /// Represents the product SKU with its shipping/handling properties
        /// This could be used when processing a partial cancel of an order.
        /// </summary>
        public OMSOrderLineItem Item { get; set; }

        /// <summary>
        /// Quantity shipped <= order's item Sold Quantity.
        /// </summary>
        /// <example>
        /// 2
        /// </example>
        public int Quantity { get; set; } 
    }
}
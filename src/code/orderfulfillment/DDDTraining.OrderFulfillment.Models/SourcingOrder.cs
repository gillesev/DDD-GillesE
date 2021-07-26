using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents an order that has been sourced.
    /// </summary>    
    public class SourcingOrder
    {
        public SourcingOrder()
        {
            this.Status = SourcingOrderStatus.Reserved;
        }

        /// <summary>
        /// Unique meaningless Sourcing order number (unique across the enterprise)
        /// This number is immutable
        /// </summary>
        /// <example>
        /// 3234-877557-5423-909452
        /// </example>
        public string Id { get; set; }

        /// <summary>
        /// See Sourcing Order Status - SourcingOrderStatus
        /// <summary>
        /// <example>
        /// 1 - Reserved
        /// </example>
        public int Status { get; set; }

        /// <summary>
        /// Paid Order which triggered the creation of the shipment.
        /// <summary>
        public CustomerOrder CustomerOrder { get; set; }

        /// <summary>
        /// Distribution center responsible for sourcing the product line items.
        /// </summary>
        public DistributionCenter SourcingLocation { get; set; }

        /// <summary>
        /// List of line items placed in the order.
        /// <summary>
        public IList<SourcingOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// Date/Time at which the shipment was created
        /// </summary>
        public DateTime CreationUTCDateTime { get; set; }

        /// <summary>
        /// Date/Time at which the shipment was last updated.
        /// </summary>
        public DateTime UpdateUTCDateTime { get; set; }         
    }
}
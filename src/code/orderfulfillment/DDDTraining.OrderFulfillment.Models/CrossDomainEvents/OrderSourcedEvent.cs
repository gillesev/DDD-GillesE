using DDDTraining.ECommerce.SharedModels;
using System;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// This message is published when an order has been sourced by a distribution center.
    /// </summary>
    public class OrderSourcedEvent: IOrderSourcedEvent
    {
        /// <summary>
        /// UTC time stamp when the order event was created. Immutable.
        /// </summary>
        public DateTime CreationUTCTimeStamp { get; set; }

        /// <summary>
        /// (REQUIRED) unique order number.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Serialized order details.
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// Reference to the Customer Order.
        /// </summary>
        public string CustomerOrderNumber { get; set; }
    }
}

using DDDTraining.ECommerce.SharedModels;
using System;

namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// When the order is fully paid (all payments have been processed)
    /// placeOrder emits this event subscribed by:
    /// - the Order Fulfillment domain,
    /// - the Customer History domain,
    /// - potentially a receipt sub system to send a customer email notification 
    /// (receipt template applied on top of the order details) 
    /// 
    /// </summary>
    public class OMSOrderPaidEvent: IOrderPaidEvent
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
        public string Order {get; set;}
    }
}
using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a shipment for a subset of/all items purchased from a single order.
    /// NOTE: this model assumes that a shipment can only be tied to a single order.
    /// </summary>    
    public class OMSShipment
    {
        /// <summary>
        /// Unique meaningless order number (unique across the enterprise)
        /// This number is immutable and is provided to the customer (customer receipt)
        /// </summary>
        /// <example>
        /// 3234-877557-5423-909452
        /// </example>
        public string ShipmentId { get; set; }

        /// <summary>
        /// See OMS Shipping Status
        /// <summary>
        /// <example>
        /// 
        /// </example>
        public int Status { get; set; }

        /// <summary>
        /// Paid Order which triggered the creation of the shipment.
        /// <summary>
        public OMSOrder Order { get; set; }

        /// <summary>
        /// List of line items placed in the order.
        /// <summary>
        public IList<OMSShipmentLineItem> LineItems { get; set; }

        /// <summary>
        /// Postal Address where the shipment will be delivered
        /// </summary>
        /// <example>
        /// 880 Eden Court, San Fransisco CA 94016 - USA
        /// </example>        
        public PostalAddress ShippingAddress { get; set; }

        /// <summary>
        /// Date when the shipment is scheduled to be delivered.
        /// </summary>
        public DateTime ScheduleDeliveryUTCDateTime { get; set; }

        /// <summary>
        /// Date when the shipment was actually delivered (if any).
        /// </summary>
        public DateTime? EffectiveDeliveryUTCDateTime { get; set; }

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
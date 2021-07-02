using System;
using System.Collections.Generic;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a Customer order placed by a customer.
    /// </summary>    
    public class CustomerOrder
    {
        public CustomerOrder()
        {
            this.Status = CustomerOrderStatus.Paid;
        }

        /// <summary>
        /// Unique meaningless order number (unique across the enterprise)
        /// This number is immutable and is provided to the customer (customer receipt)
        /// </summary>
        /// <example>
        /// 1111-222333-4444-5556666
        /// </example>
        public string OrderNumber { get; set; }

        /// <summary>
        /// See Customer Order Status
        /// <summary>
        /// <example>
        /// 2 (Paid)
        /// </example>
        public int Status { get; set; }

        /// <summary>
        /// We do not need to know about the customer
        /// so the customer model used in the Order Fulfillment domain is reduced to its unique Id.
        /// <summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// List of line items placed in the order.
        /// <summary>
        public IList<CustomerOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// Date/Time at which the order was created
        /// </summary>
        public DateTime CreationUTCDateTime { get; set; }

        /// <summary>
        /// Date/Time at which the order was last updated.
        /// </summary>
        public DateTime UpdateUTCDateTime { get; set; }         
    }
}
namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Represents an order placed by a customer.
    /// </summary>    
    public class RetailOrder
    {
        /// <summary>
        /// Unique meaningless order number (unique across the enterprise)
        /// This number is immutable and is provided to the customer (customer receipt)
        /// </summary>
        /// <example>
        /// 1111-222333-4444-5556666
        /// </example>
        public string OrderNumber { get; set; }

        /// <summary>
        /// See RetailOrderStatus
        /// <summary>
        /// <example>
        /// 0 (Estimated)
        /// </example>
        public int Status { get; set; }

        /// <summary>
        /// Customer associated with the order.
        /// <summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Postal Address where the order is being shipped
        /// </summary>
        /// <example>
        /// 880 Eden Court, San Fransisco CA 94016 - USA
        /// </example>        
        public PostalAddress ShippingAddress { get; set; }

        /// <summary>
        /// List of line items placed in the order.
        /// <summary>
        public IList<RetailOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// List of payment methods that the customer will use to pay the order.
        /// <summary>
        /// <example>
        /// 1: GC 67423584745954578 for $5.00, 2: Credit Card 4147xxxxxxxxxxxx for 13.73
        /// </example>
        public IList<RetailOrderPaymentRequest> PaymentRequests { get; set; }
    }
}
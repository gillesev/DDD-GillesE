using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents an order placed by a customer.
    /// Is an entity
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
        /// </summary>
        /// <example>
        /// 0 (Estimated)
        /// </example>
        public int Status { get; set; }

        /// <summary>
        /// Customer associated with the order.
        /// </summary>
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
        /// </summary>
        public IList<RetailOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// List of payments used to pay the order.
        /// </summary>
        /// <example>
        /// 1: GC 67423584745954578 for $5.00, 2: Credit Card 4147xxxxxxxx8232 for 13.73
        /// </example>
        public IList<RetailOrderPayment> Payments { get; set; }

        /// <summary>
        /// List of shipping options selected by the customer
        /// </summary>
        /// <example>
        /// 1: 2-Day Delivery for line article SKU 24362436, 2: Standard for remaining items.
        /// </example>
        public IList<ShippingOptions> ShippingOptions { get; set; }

        /// <summary>
        /// Date/Time at which the order was created
        /// </summary>
        public DateTime CreationUTCDateTime { get; set; }

        /// <summary>
        /// Date/Time at which the order was last updated.
        /// </summary>
        public DateTime UpdateUTCDateTime { get; set; }

        void CreateOrder(
            DDDTraining.Transactions.Models.ShoppingCart cart,
            PostalAddress shippingAddress,
            IList<ShippingOptions> shippingOptions,
            IList<PaymentMethodAllocation> paymentAllocations) {
            // this method will be creating the entire order details and call into:
            // - an injected discount service (other domain)
            // - an injected tax service (other domain)
        } 
    }
}
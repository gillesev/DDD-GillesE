using System;

namespace DDDTraining.CustomerHistory.Models
{
    /// <summary>
    /// Represents a Customer identified at the time an order is placed
    /// </summary>
    /// <remarks>
    /// Customer core information with:
    /// - Customer Id: unique across the enterprise
    /// - Shipping Address as this determines Taxes and/or Shipment options
    /// - Customer's list of payment methods as this determines promotions evaluation
    /// - Customer segmentation which determines promotions evaluation, coupons, gitcards or points on file.
    /// </remarks>
    public class Customer
    {
        /// <summary>
        /// Unique (across the enterprise/channels) meaningless Customer Identifier.
        /// </summary>
        /// <example>
        /// 56789120345
        /// </example>
        public string CustomerId { get; set; }

        /// <summary>
        /// Customer's active Shipping Postal Address
        /// </summary>
        /// <example>
        /// 880 Bunny Court, San Marcos CA 92078 - USA
        /// </example>        
        public PostalAddress ShippingAddress { get; set; }

        /// <summary>
        /// Customer's set of active payment methods
        /// </summary>
        /// <example>
        /// CC 4147000000005001
        /// GC 62834568346584
        /// </example>
        /// <example>
        /// Private Label 4147000000009999
        /// </example>
        public List<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// Represents a membership list of Customer Segments.
        /// This list varies over time as a customer may be promoted or dropped from a certain segment.
        /// This list may not exist (brand new customer with no history)
        /// </summary>
        /// <example>
        /// GoldMember, PrivateLabel
        /// </example>
        /// <example>
        /// PlatinumMember
        /// </example>        
        public List<string> Segments {get; set;}
    }
}

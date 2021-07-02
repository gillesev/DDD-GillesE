namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents an order placed by a customer.
    /// Is an entity
    /// </summary>    
    public class ShippingOptions
    {
        /// <summary>
        /// Order's line this option applies to.
        /// </summary>
        public int ItemLineNumber { get; set; }
        /// <summary>
        /// Shipping Delivery option.
        /// </summary>
        public int ShippingDeliveryType { get; set; }
    }
}
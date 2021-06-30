namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Payment applied to an order when the order is placed.
    /// </summary>
    public class RetailOrderPaymentRequest
    {
        /// <summary>
        /// Account used to pay. It may be a customer's account on file or not
        /// depending on whether the customer did sign in or it is a guest visitor.
        /// </summary>
        PaymentMethod Account {get; set;}

        /// <summary>
        /// Full/Partial Payment Amount
        /// </summary>
        /// <example>
        /// 20.00
        /// </example>
        public decimal Amount { get; set; }

        /// <summary>
        /// Card Verification Code (3 digits in the back of the card)
        /// </summary>
        public string CVV { get; set; }
    }
}
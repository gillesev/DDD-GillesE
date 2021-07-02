namespace DDDTraining.Transactions.APIs
{
    /// <summary>
    /// Payment method selected by the customer to pay a certain amount of the order total amount.
    /// </summary>
    public class PaymentMethodAllocationDTO
    {
        /// <summary>
        /// Unique ID for this customer payment method.
        /// </summary>

        public string PaymentMethodId { get; set; }


        /// <summary>
        /// Full/Partial Payment Amount
        /// </summary>
        /// <example>
        /// 20.00
        /// </example>
        public decimal Amount { get; set; }
    }
}
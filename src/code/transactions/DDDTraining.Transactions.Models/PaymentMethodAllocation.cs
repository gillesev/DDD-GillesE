namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Payment method selected by the customer to pay a certain amount of the order total amount.
    /// </summary>
    public class PaymentMethodAllocation
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
    }
}
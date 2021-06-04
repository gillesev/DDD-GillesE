namespace DDDTraining.ShoppingCart.Models
{
    /// <summary>
    /// Payment applied to a shopping cart during checkout process.
    /// </summary>
    public class ShoppingCartPayment
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
        /// 5.73
        /// </example>
        public decimal Amount { get; set; }
    }
}
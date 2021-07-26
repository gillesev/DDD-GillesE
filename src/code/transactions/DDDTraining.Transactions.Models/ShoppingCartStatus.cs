namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Shopping Cart Status
    /// </summary>
    /// <example>
    /// 1 - Transacted
    /// </example>
    public class ShoppingCartStatus
    {
        /// <summary>
        /// Represents a Shopping Cart newly created
        /// </summary>
        public const int Created = 0;

        /// <summary>
        /// Represents a Shopping Cart being checked out.
        /// This drives what can be done to the cart, e.g. customer cannot add items any more
        /// but needs to provide payment (payments/coupons) and shipping information
        /// </summary>
        public const int Checkout = 1;

        /// <summary>
        /// Represents a Shopping cart that has been transacted/purchased.
        /// </summary>
        public const int Purchased = 2;

        /// <summary>
        /// Represents a Shopping that the customer abandonned before attempting to transact it.
        /// </summary>
        public const int Abandonned = 3;
    }
}
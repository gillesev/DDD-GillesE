namespace DDDTraining.ShoppingCart.Models
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
        /// </summary>
        public const int Checkout = 1;

        /// <summary>
        /// Represents a Shopping that the customer abandonned before attempting to transact it.
        /// </summary>
        public const int Abandonned = 2;
    }
}
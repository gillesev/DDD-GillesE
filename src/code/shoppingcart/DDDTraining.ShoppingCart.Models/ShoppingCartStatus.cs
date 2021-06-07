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
        /// Represents a shopping cart which items have been purchased
        /// and for which corresponds a sale.
        /// </summary>
        public const int Transacted = 1;
        /// <summary>
        /// Represents a Shopping that the customer abandonned before attempting to transact it.
        /// </summary>
        public const int Abandonned = 2;
        /// <summary>
        /// Represents a Shopping cart abandonned after at least 1 attempt to transact it failed
        /// </summary>
        public const int InError = 3;
    }
}
namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Represents a type of transaction.
    /// </summary>
    /// <example>
    /// 1 (Sale)
    /// </example>
    /// <example>
    /// 2 (Return)
    /// </example>
    /// <example>
    /// 3 (Exchange)
    /// </example>    
    public class PaymentMethod
    {
        /// <summary>
        /// Represents a SALE transaction.
        /// </summary>
        public const int Sale = 1;

        /// <summary>
        /// Represents a RETURNS transaction.
        /// </summary>
        public const int Sale = 2;

        /// <summary>
        /// Represents an EXCHANGE transaction.
        /// </summary>
        public const int Sale = 3;
    }
}
namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Retail Order Status
    /// </summary>
    /// <example>
    /// 1 - Transacted
    /// </example>
    public class OMSOrderStatus
    {
        /// <summary>
        /// Represents an order fully paid.
        /// </summary>
        public const int Paid = 1;

        /// <summary>
        /// Represents an order completed/shipped.
        /// </summary>
        public const int Fulfilled = 2;

        /// <summary>
        /// Represents an order fully paid.
        /// </summary>
        public const int Cancelled = 3;        
    }
}
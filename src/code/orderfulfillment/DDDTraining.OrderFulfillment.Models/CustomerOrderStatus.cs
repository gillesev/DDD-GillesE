namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Purchase Order Status
    /// </summary>
    /// <example>
    /// 2 - Sourced
    /// </example>
    public class CustomerOrderStatus
    {
        /// <summary>
        /// Represents a Purchase order placed by a customer.
        /// </summary>
        public const int Paid = 1;

        /// <summary>
        /// Reaches this status when all associated Sourced orders have been sourced
        /// </summary>
        public const int Sourced = 2;

        /// <summary>
        /// Represents an order that has been completed (delivered/shipped)
        /// </summary>
        public const int Completed = 2;

        /// <summary>
        /// Represents an order that has been cancelled by the customer.
        /// </summary>
        public const int Cancelled = 4;
    }
}
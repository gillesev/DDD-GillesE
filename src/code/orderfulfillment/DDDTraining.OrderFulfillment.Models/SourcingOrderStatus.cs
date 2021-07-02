namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Sourcing Order Status
    /// </summary>
    /// <example>
    /// 1 - Reserved
    /// </example>
    public class SourcingOrderStatus
    {
        /// <summary>
        /// The sourcing center order has been reserved.
        /// </summary>
        public const int Reserved = 1;

        /// <summary>
        /// Sourcing center has completed the sourcing of this order.
        /// </summary>
        public const int Completed = 2;

        /// <summary>
        /// Sourcing order has been cancelled.
        /// </summary>
        public const int Cancelled = 3;
    }
}
namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Retail Order Status
    /// </summary>
    /// <example>
    /// 1 - Transacted
    /// </example>
    public class RetailOrderStatus
    {
        /// <summary>
        /// Represents an order about to be placed by a customer. Tax Amounts are estimated.
        /// as they depend on shipping address.
        /// </summary>
        public const int Estimated = 0;

        /// <summary>
        /// Represents an order that has been placed by a customer.
        /// </summary>
        public const int Placed = 1;

        /// <summary>
        /// Represents an order which payment(s) have been approved.
        /// </summary>
        public const int Transacted = 2;

        /// <summary>
        /// Represents an order that has been cancelled by a customer after having been placed.
        /// </summary>
        public const int Cancelled = 3;

        /// <summary>
        /// Represents an order which payment did not get approved.
        /// </summary>
        public const int InError = 4;        
    }
}
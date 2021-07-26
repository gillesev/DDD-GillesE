namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Retail Order Status
    /// </summary>
    /// <example>
    /// 1 - Paid
    /// </example>
    public class RetailOrderStatus
    {
        /// <summary>
        /// Represents an order about to be placed by a customer. Tax Amounts are estimated.
        /// as they depend on shipping address.
        /// </summary>
        public const int Created = 0;

        /// <summary>
        /// Represents an order which payment(s) have been approved.
        /// </summary>
        public const int Paid = 1;

        /// <summary>
        /// Represents an order which payment(s) did not all get approved.
        /// </summary>
        public const int InError = 2;
    }
}
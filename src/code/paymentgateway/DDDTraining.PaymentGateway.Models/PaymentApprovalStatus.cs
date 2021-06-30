namespace DDDTraining.PaymentGateway.Models
{
    /// <summary>
    /// Payment Approval Status
    /// </summary>
    /// <example>
    /// 1 - Approved
    /// </example>
    public class PaymentApprovalStatus
    {
        /// <summary>
        /// The payment charge is approved by the authorizer.
        /// </summary>
        public const int Approved = 1;

        /// <summary>
        /// The payment charge is declined.
        /// </summary>
        public const int Declined = 2;

        /// <summary>
        /// Merchant must call the authorizer to obtain an approval code by phone.
        /// </summary>
        public const int CallForReferral = 3;           
    }
}
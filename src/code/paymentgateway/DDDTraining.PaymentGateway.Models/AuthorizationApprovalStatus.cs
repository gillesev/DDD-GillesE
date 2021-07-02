namespace DDDTraining.PaymentGateway.Models
{
    /// <summary>
    /// Authorization request's Approval Status
    /// </summary>
    /// <example>
    /// 1 - Approved
    /// </example>
    public class AuthorizationApprovalStatus
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
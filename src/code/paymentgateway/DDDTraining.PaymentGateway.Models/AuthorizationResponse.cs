namespace DDDTraining.PaymentGateway.Models
{
    /// <summary>
    /// Response from an authorization request
    /// </summary>
    public class PaymentResponse
    {
        /// <summary>
        /// (REQUIRED) This is the associated request's Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Authorizer gateway return code. Provides context as to what happened as far as the gateway is concerned.
        /// This could trigger an automatic timeout reversal for example if this code equates to an unknown error.
        /// </summary>
        public string ReturnCode { get; set; }

        /// <summary>
        /// (REQUIRED) Response approval status:
        /// 1: Approved, 2: Declined, 3:Call for Referral
        /// </summary>        
        public int ApprovalStatus { get; set; }

        /// <summary>
        /// (REQUIRED) Approved Amount (could be less that the requested amount, e.g. this is a partial amount)
        /// Could be 0.00 if status is Declined.
        /// </summary>
        /// <example>
        /// 15.00
        /// </example>
        public decimal ApprovedAmount { get; set; }

        /// <summary>
        /// Authorizer/Gateway approval code.
        /// May be NULL if the status is Declined or Call for Referral.
        /// </summary>
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Void ID: needs to be provided if/when voiding this request.
        /// </summary>
        public string VoidId { get; set; }
    }
}
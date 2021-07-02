namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents the minimum CONTRACT that the payment gateway provides to describe a response to a payment authorization request.
    /// </summary>
    public interface IAuthorizationResponse: IAuthorizationIdentifiable
    {
        /// <summary>
        /// Response approval status:
        /// 1: Approved, 2: Declined, 3:Call for Referral
        /// </summary>        
        int ApprovalStatus { get; set; }

        /// <summary>
        /// Approved Amount (could be less that the requested amount, e.g. this is a partial amount)
        /// 0.00 if status is not (Approved, CallForReferral).
        /// </summary>
        /// <example>
        /// 15.99
        /// </example>
        decimal ApprovedAmount { get; set; }

        /// <summary>
        /// Authorizer/Gateway approval code.
        /// Could be NULL if the status is Declined or Call for Referral.
        /// </summary>
        string ApprovalCode { get; set; }

        /// <summary>
        /// Returned only if approved response.
        /// MUST be used to void the corresponding request.
        /// </summary>
        string VoidId { get; set; }
    }
}
namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Payment status event to be emitted by the Payment Gateway domain.
    /// </summary>
    public class PaymentStatusEvent
    {
        /// <summary>
        /// This is used by the requesting system to correlate this status event 
        /// with its payment request event.
        /// </summary>
        public string ExternalRequestId { get; set; }

        /// <summary>
        /// Response approval status:
        /// 1: Approved, 2: Declined, 3:Call for Referral
        /// </summary>        
        public int ApprovalStatus { get; set; }

        /// <summary>
        /// Approved Amount (could be less that the requested amount, e.g. this is a partial amount)
        /// Could be 0.00 if status is Declined.
        /// </summary>
        /// <example>
        /// 15.00
        /// </example>
        public decimal ApprovedAmount { get; set; }

        /// <summary>
        /// Authorizer/Gateway approval code.
        /// Could be NULL if the status is Declined or Call for Referral.
        /// </summary>
        public string ApprovalCode { get; set; }        
    }
}
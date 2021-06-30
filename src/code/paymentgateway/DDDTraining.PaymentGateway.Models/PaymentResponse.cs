namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Payment response to a payment request
    /// </summary>
    public class PaymentStatusEvent
    {
        /// <summary>
        /// Internal unique (meaningless) Id that correlates a response to a request.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Response approval status:
        /// 1: Approved, 2: Declined, 3:Call for Referral
        /// </summary>        
        public int ApprovalStatus { get; set; }

        /// <summary>
        /// Approved Amount (could be less that the requested amount, e.g. this is a partial amount)
        /// Could be 0.00 if status is Declined
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
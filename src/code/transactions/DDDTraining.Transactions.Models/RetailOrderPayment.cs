namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Payment applied to an order.
    /// </summary>
    public class RetailOrderPayment
    {
        /// <summary>
        /// (REQUIRED) Internal unique (meaningless) Id for this payment request.
        /// Since we can have multiple payment requests for a given order, we need a discriminant.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Masked Credit Card token last 4 digits.
        /// The request Id can be used to find the actual payment request/response from the Payment gateway system
        /// if need be.
        /// </summary>
        public string PaymentAccountLast4 { get; set; }        

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
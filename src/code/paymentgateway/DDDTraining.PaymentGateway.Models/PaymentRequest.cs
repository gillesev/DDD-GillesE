namespace DDDTraining.PaymentGateway.Models
{
    /// <summary>
    /// Payment request made by a system (could be the Order Management system)
    /// to the Payment gateway system
    /// </summary>
    public class PaymentRequest
    {
        /// <summary>
        /// This is a meaningless number that the requesting system is responsible for
        /// generating and that the payment gateway system honors to echo back when sending
        /// messages back.
        /// </summary>
        public string ExternalRequestId { get; set; }

        /// <summary>
        /// Internal unique (meaningless) Id for this payment request.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Account Credit Card/Debit Card Token
        /// or 
        /// Gift Card # in clear
        /// We do not concern ourselves with PCI data sensitivity.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Method Type such as Credit/Debut/GC/PrivateLabel
        /// This may drive Promotion qualification.
        /// NOTE: C# enum types are not easy to evolve and are not extensible.
        /// therefore preferred a class with constants.
        /// See PaymentMethodType class.
        /// </summary>
        /// <example>
        /// Credit
        /// </example>
        public int PaymentMethodType { get; set; }

        /// <summary>
        /// Requested Amount
        /// </summary>
        /// <example>
        /// 20.00
        /// </example>
        public decimal Amount { get; set; }

        /// <summary>
        /// Date when the method of payment expires
        /// </summary>
        /// <example>
        /// 0825
        /// </example>
        public string ValidThru { get; set; }

        /// <summary>
        /// Card Verification Code (3 digits in the back of the card)
        /// </summary>
        public string CVV { get; set; }        
    }
}
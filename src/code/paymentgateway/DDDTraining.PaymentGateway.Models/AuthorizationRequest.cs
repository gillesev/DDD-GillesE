namespace DDDTraining.PaymentGateway.Models
{
    /// <summary>
    /// Authorization request submited to the authorizer gateway (First Data/PaymentTec ETC...)
    /// </summary>
    public class AuthorizationRequest
    {
        /// <summary>
        /// (REQUIRED) id provided by the requesting system and is used to correlate request and response
        /// for the requesting system.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Internal unique (meaningless) Id for this payment request.
        /// The system will probably use a Store and Forward design where the request
        /// is saved ahead of being sent to the authorizer gateway.
        /// </summary>
        public string Id { get; set; }

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
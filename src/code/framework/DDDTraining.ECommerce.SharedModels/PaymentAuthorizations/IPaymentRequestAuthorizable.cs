namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents a payment that can be authorized
    /// This is the minimum CONTRACT that needs to be met for the payment gateway to be able to process a payment request.
    /// </summary>
    public interface IPaymentRequestAuthorizable: IAuthorizationIdentifiable
    {
        /// <summary>
        /// Indicates whether this request is a timeout reversal
        /// </summary>
        bool IsReversal { get; set; }

        /// <summary>
        /// If IsVoid is FALSE, this is REQUIRED.
        /// Account Credit Card/Debit Card Token
        /// or 
        /// Gift Card # in clear
        /// This field will be ENCRYPTED as this event will travel between domains.
        /// </summary>
        string AccountId { get; set; }

        /// <summary>
        /// If IsVoid is FALSE, this is REQUIRED.
        /// Method Type such as Credit/Debit/GC/PrivateLabel
        /// This may drive Promotion qualification.
        /// NOTE: C# enum types are not easy to evolve and are not extensible.
        /// therefore preferred a class with constants.
        /// See PaymentMethodType class.
        /// </summary>
        /// <example>
        /// Credit
        /// </example>
        int PaymentMethodType { get; set; }

        /// <summary>
        /// (REQUIRED) Requested Amount > 0
        /// </summary>
        /// <example>
        /// 20.33
        /// </example>
        decimal Amount { get; set; }
    }
}

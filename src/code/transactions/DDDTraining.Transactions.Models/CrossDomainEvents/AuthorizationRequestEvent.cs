using DDDTraining.ECommerce.SharedModels;
using System;

namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Authorization request made by a system (could be the Transaction/Shopping Cart system)
    /// to the Payment gateway system
    /// </summary>
    public class PaymentRequestEvent: IPaymentRequestEvent
    {
        /// <summary>
        /// UTC time stamp when a request or response was created. Immutable.
        /// </summary>
        public DateTime CreationUTCTimeStamp { get; set; }

        /// <summary>
        /// id provided by the requesting system and is used to correlate request and response.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether this request is a timeout reversal
        /// </summary>
        public bool IsReversal { get; set; }

        /// <summary>
        /// Used when voiding an existing approved request.
        /// and corresponds to the VoidId received in the request's response that needs to be voided.
        /// </summary>
        public bool VoidId { get; set; }

        /// <summary>
        /// If IsVoid is FALSE, this is REQUIRED.
        /// Account Credit Card/Debit Card Token
        /// or 
        /// Gift Card # in clear
        /// This field will be ENCRYPTED as this event will travel between domains.
        /// </summary>
        public string AccountId { get; set; }

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
        public int PaymentMethodType { get; set; }

        /// <summary>
        /// Requested Amount > 0
        /// </summary>
        /// <example>
        /// 20.33
        /// </example>
        public decimal Amount { get; set; }       
    }
}
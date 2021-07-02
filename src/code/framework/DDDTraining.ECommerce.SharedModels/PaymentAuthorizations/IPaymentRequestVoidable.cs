using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents a payment that can be voided
    /// This is the minimum CONTRACT that needs to be met for the payment gateway to be able to void a given payment request.
    /// </summary>
    public interface IPaymentRequestVoidable: IAuthorizationIdentifiable
    {
        /// <summary>
        /// If this request is a void request (IsVoid is TRUE), this field is required
        /// and corresponds to the VoidId received in the request's response that needs to be voided.
        /// </summary>
        bool VoidId { get; set; }
    }
}

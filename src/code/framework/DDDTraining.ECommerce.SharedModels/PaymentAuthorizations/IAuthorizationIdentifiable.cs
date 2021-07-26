using System;

namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents a payment request/response that can be identified uniquely (accross the enterprise)
    /// This is the minimum CONTRACT that needs to be met for the payment gateway to identity a request/response.
    /// </summary>
    public interface IAuthorizationIdentifiable
    {
        /// <summary>
        /// id provided by the requesting system and is used to correlate request and response
        /// for the requesting system.
        /// </summary>
        string RequestId { get; set; }
    }
}

namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents an event that the payment gateway domain can emit as a response to a payment request event.
    /// </summary>
    public interface IPaymentResponseEvent: ITimedEvent, IAuthorizationResponse
    {
    }
}
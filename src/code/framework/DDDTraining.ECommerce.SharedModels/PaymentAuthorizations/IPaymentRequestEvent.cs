namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents a payment event that can be ingested by the payment gateway domain.
    /// </summary>
    public interface IPaymentRequestEvent: ITimedEvent, IPaymentRequestAuthorizable
    {
    }
}

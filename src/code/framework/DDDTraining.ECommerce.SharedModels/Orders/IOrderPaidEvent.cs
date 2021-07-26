namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// This represents the message published when an order has been paid. 
    /// </summary>
    
    public interface IOrderPaidEvent: IOrderEvent
    {
        /// <summary>
        /// Serialized order in a Industry Standard format (like a Retail POS Log but for an OMS system)
        /// </summary>
        string Order {get; set;}
    }
}
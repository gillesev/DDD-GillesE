namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// This represents the message published when an order has been paid. 
    /// </summary>
    
    public interface IOrderSourcedEvent: IOrderEvent
    {
        /// <summary>
        /// Serialized order in a Industry Standard format (like a Retail POS Log but for an OMS system)
        /// </summary>
        string Order {get; set;}

        /// <summary>
        /// Reference to the Customer Order.
        /// </summary>
        string CustomerOrderNumber { get; set; }
    }
}
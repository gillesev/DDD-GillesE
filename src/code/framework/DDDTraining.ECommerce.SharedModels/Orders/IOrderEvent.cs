namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents an event that happened to an order.
    /// </summary>    
    public interface IOrderEvent: ITimedEvent
    {
        /// <summary>
        /// (REQUIRED) unique order number.
        /// </summary>
        string OrderNumber { get; set; }       
    }
}
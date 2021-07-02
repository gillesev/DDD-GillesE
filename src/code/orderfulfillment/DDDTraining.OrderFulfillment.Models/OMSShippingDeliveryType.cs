namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Shipping Option Type
    /// </summary>
    /// <example>
    /// 2 Day delivery
    /// </example>
    public class OMSShippingDeliveryType
    {
        /// <summary>
        /// the item will be delivery the next business day
        /// </summary>
        public const int OneDayDelivery = 0;
        /// <summary>
        /// the item will be delivery within the next 2 business days
        /// </summary>
        public const int TwoDayDelivery = 1;
        /// <summary>
        /// the item will be delivered with standard ground rules.
        /// </summary>
        public const int Standard = 2;
    }
}
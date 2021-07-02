using System;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a requirement/constraint for shipping a given order line item.
    /// </summary>
    /// <example>
    /// 2 Day Delivery by 07/01/2021 12:00PM UTC for Item SKU 3462143216346 Line # 1
    /// </example>
    public class OMSShippingRequirement
    {
        /// <summary>
        /// Represents the order item's line # this shipping requirement applies to.
        /// see OMSShippingDeliveryType.
        /// </summary>
        /// <example>
        /// 1: TwoDayDelivery
        /// </example>        
        public int OMSShippingMethodType { get; set; }

        /// <summary>
        /// Date/Time in UTC format when the item is due to be delivered at its destination address.
        /// </summary>
        /// <example>
        /// 07/01/2021 12:00 PM UTC.
        /// </example>
        public DateTime DueDateTimeUTC { get; set; }
    }
}
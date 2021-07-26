using DDDTraining.ECommerce.SharedModels;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a Sourcing/Distribution/Wharehouse center.
    /// </summary>
    public class DistributionCenter
    {
        /// <summary>
        /// Unique Id identifying a Retailer's distribution center.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Wharehouse Code
        /// </summary>

        public string Code { get; set; }

        /// <summary>
        /// Physical location for the distribution center.
        /// </summary>
        public PostalAddress Location { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represent a Product with the prism of the order fulfillment/shipping domain.
    /// </summary>
    public class OMSProductItem
    {
        /// <summary>
        /// Represents the Retailer Merchandise SKU unique identifer (not serial #)
        /// </summary>
        /// <example>
        /// 976541
        /// </example>
        public int SKU { get; set; }

        /// <summary>
        /// Short Description to be rendered on cart on-line or in email receipt
        /// </summary>
        /// <example>
        /// Baby Monitor Samsung
        /// </example>
        public string ProductShortDescription { get; set; }

        /// <summary>
        /// item's single unit Weight.
        /// </summary>
        /// <example>
        /// 0.15 Kg
        /// </example>
        public decimal WeightInKgs { get; set; }

        /// <summary>
        /// item's single unit length in meters.
        /// </summary>
        /// <example>
        /// 0.15m
        /// </example>
        public decimal LengthInMeters { get; set; }

        /// <summary>
        /// item's single unit width in meters.
        /// </summary>
        /// <example>
        /// 0.15m
        /// </example>
        public decimal WidthInMeters { get; set; }

        /// <summary>
        /// item's single unit height in meters.
        /// </summary>
        /// <example>
        /// 0.15m
        /// </example>
        public decimal HeightInMeters { get; set; }

        /// <summary>
        /// This item may require special handling and special delivery.
        /// </summary>
        /// <example>
        /// Flamable (the model is not detailed at this point)
        /// </example>
        public int SpecialHandlingCategory { get; set; }               
    }
}

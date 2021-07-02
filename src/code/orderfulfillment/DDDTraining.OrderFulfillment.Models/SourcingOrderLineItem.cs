namespace DDDTraining.OrderFulfillment.Models
{
    /// <summary>
    /// Represents a line item in a shipment.
    /// </summary>
    /// <example>
    /// 2 bottles of Acetominophen
    /// </example>
    public class SourcingOrderLineItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 shipment lines
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int LineNumber { get; set; }

        /// <summary>
        /// Associated Customer order's line item
        /// </summary>
        /// <example>
        /// CO Line Number # 2
        /// </example>
        public CustomerOrderLineItem CustomerOrderLineItem { get; set; }

        /// <summary>
        /// Quantity shipped <= PO's item Sold Quantity.
        /// </summary>
        /// <example>
        /// 2
        /// </example>
        public int Quantity { get; set; }
    }
}
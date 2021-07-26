namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents a discount applied to an item based on a promotion (before taxes)
    /// </summary>
    public class RetailOrderLineItemDiscount
    {
        /// <summary>
        /// Unique Id for the Promotion qualified at the time the cart was evaluated.
        /// This can also represent a one-time or manufacture coupon.
        /// </summary>
        /// <example>
        /// XC1234567
        /// </example>
        public string PromotionId { get; set; }

        /// <summary>
        /// Short Description for the Discount applied to the shopping cart's item.
        /// </summary>
        /// <example>
        /// XMas Super Saver - 5$ OFF
        /// </example>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Computed Amount for the given item #.
        /// </summary>
        /// <example>
        /// 5.00
        /// </example>
        public decimal DiscountAmount { get; set; }
    }
}
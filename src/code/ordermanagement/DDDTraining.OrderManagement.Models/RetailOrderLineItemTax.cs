namespace DDDTraining.OrderManagement.Models
{
    /// <summary>
    /// Represents a pro-rated tax amount for a line item
    /// </summary>    
    public class RetailOrderLineItemTax
    {
        /// <summary>
        /// Tax Jurisdiction or Tax Identifier.
        /// </summary>
        /// <example>
        /// 911 Comm Tax
        /// </example>
        public string TaxId {get; set; }

        /// <summary>
        /// Short Description for the Tax.
        /// </summary>
        /// <example>
        /// CA State Tax
        /// </example>
        /// <example>
        /// San Diego County Tax
        /// </example>              
        public string TaxDescription {get; set;}

        /// <summary>
        /// Tax amount for the order line item.
        /// </summary>
        /// <example>
        /// 0.73
        /// </example>
        public decimal TaxAmount {get; set;}
    }
}
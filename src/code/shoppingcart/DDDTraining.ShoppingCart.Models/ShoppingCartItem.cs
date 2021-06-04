using System.Collections.Generic;

namespace DDDTraining.ShoppingCart.Models
{
    /// <summary>
    /// Represents an item added to a shopping cart
    /// </summary>
    public class ShoppingCartItem
    {
        /// <summary>
        /// Represents a unique increment to distinguish 2 lines for the same product SKU
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int ItemNumber { get; set; }

        /// <summary>
        /// Represents the product added to the cart
        /// </summary>
        public ProductItem Product { get; set; }

        /// <summary>
        /// Quantity purchased
        /// </summary>
        /// <example>
        /// 5
        /// </example>
        public int Quantity { get; set; }

        /// <summary>
        /// List of discounts applied at various events: when the item was added to the shopping cart
        /// based on:
        /// - the date/time the item was added to the cart,
        /// or 
        /// - the customer segmentation
        /// or
        /// - the customer's specific method of payment at checkout.
        /// </summary>
        /// <example>
        /// Discount Amt=2.50 Desc=Gold -5% for any purchase > $50.00
        /// Discount Amt=1.00 Desc=XMas Super Saver from 12/01 to 01/31.
        /// </example>
        public List<ShoppingCartItemDiscount> Discounts { get; set; }

        /// <summary>
        /// Total Taxes applied (once customer's shipping address is)
        /// </summary>
        /// <example>
        /// 2.76
        /// </example>
        public decimal TotalTaxes { get; set; }

        /// <summary>
        /// Net Total = (Base Price - Promotions) * Quantity + Taxes
        /// </summary>
        /// <example>
        /// 81.34
        /// </example>        
        public decimal NetTotal { get; set; }
    }
}
using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.ShoppingCart.Models
{
    /// <summary>
    /// Represents a customer's purchase (immutable) as the result of a shopping cart being transacted.
    /// </summary>
    public class RetailPosLog
    {
        /// <summary>
        /// Unique (meaningless) Id for a cart.
        /// The sale that resulted from transacting the shopping cart.
        /// Sale Id == Cart session Id.
        /// </summary>
        public string Id {get; set;}

        /// <summary>
        /// Retail POS Log contains the transactions details as far as:
        /// - item lines
        /// - item line discounts
        /// - taxes
        /// - customer
        /// - payments (Authorization Codes/GC Points ETC...)
        /// - Totals
        /// May be an XML Retail Industry format document.
        /// </summary>
        public string Log {get; set;}

        /// <summary>
        /// Date/Time at which the cart items and prices was last evaluated in UTC format.
        /// </summary>
        public DateTime UTCDateTimeCreated { get; set; }
    }
}

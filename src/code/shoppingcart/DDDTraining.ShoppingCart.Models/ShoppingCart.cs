using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.ShoppingCart.Models
{
    /// <summary>
    /// Represents a customer's shopping cart purchasing retail items/services online.
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// Associated customer (once customer has signed in)
        /// May not exist when the first item is added to the cart.
        /// May not be required at time of checkout.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// List of Product items added to the cart
        /// The list might be empty.
        /// </summary>
        public List<ShoppingCartItem> Items { get; set; }

        /// <summary>
        /// Postal Address the items will be shipped to.
        /// Determines prices and shipping options.
        /// Is Required at time of checkout.
        /// </summary>
        public PostalAddress ShippingAddress {get; set;}

        /// <summary>
        /// Payment Amounts applied to the cart. It could be a list as customer could elect to apply some points or 
        /// a Gift Card balance and pay the remaining amount with his credit card on file.
        /// </summary>
        public List<ShoppingCartPayment> AppliedPayments { get; set; }

        /// <summary>
        /// Date/Time at which the cart items and prices was last evaluated in UTC format.
        /// </summary>
        public DateTime CartEvaluationUTCDateTime { get; set; }
    }
}

using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents a customer's shopping cart purchasing retail items/services online.
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// Unique (meaningless) Id for a cart.
        /// even if never transacted, the cart may be saved for later retrieval or for analysis.
        /// </summary>
        public string Id {get; set;}

        /// <summary>
        /// Status from Created to Transacted/Abandonned/InError
        /// See Shopping Cart status.
        /// </summary>
        public int Status { get; set; }

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
        /// Cart's total amount before taxes
        /// </summary>
        public decimal GrossTotalAmount {get; set;}      

        /// <summary>
        /// Date/Time at which the cart was created
        /// </summary>
        public DateTime CreationUTCDateTime { get; set; }

        /// <summary>
        /// Date/Time at which the cart was last updated.
        /// </summary>
        public DateTime UpdateUTCDateTime { get; set; }        
    }
}

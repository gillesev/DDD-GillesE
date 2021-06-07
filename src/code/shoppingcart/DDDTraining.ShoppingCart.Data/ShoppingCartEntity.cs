using System;
using System.Collections.Generic;

namespace DDDTraining.ShoppingCart.Data
{
    /// <summary>
    /// Represents a customer's shopping cart to be persisted
    /// </summary>
    public class ShoppingCartEntity
    {
        /// <summary>
        /// Unique (meaningless) Id for a cart.
        /// </summary>
        public string Id {get; set;}

        /// <summary>
        /// Status from Created to Transacted/Abandonned/InError.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Associated customer (once customer has signed in)
        /// May be Null.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// List of Product items added to the cart
        /// The list might be empty.
        /// </summary>
        public List<ShoppingCartItemEntity> Items { get; set; }

        /// <summary>
        /// Date-Time the cart was created.
        /// </summary>
        public DateTime UTCDateCreated { get; set; }

        /// <summary>
        /// Date-Time the cart was last modified.
        /// </summary>
        public DateTime UTCDateModified { get; set; }        
    }
}

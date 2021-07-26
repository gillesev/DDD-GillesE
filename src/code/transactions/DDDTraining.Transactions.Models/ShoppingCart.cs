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


        /// <summary>
        /// Adds an item to the cart and recomputes the entire cart.
        /// </summary>
        /// <param name="sku">Product SKU to be added to the cart</param>
        /// <param name="quantity">Quantity being purchased</param>
        /// <returns>Updated shopping cart</returns>
        void AddItem(
            int sku, 
            int quantity) {
            // performs some validation logic (like sku allowed with other skus ETC...)
            // from the sku, asks a product service ??? to fetch the product for that sku
            // creates a new ShoppingCartItem and adds it to the collection
            // re-evaluates totals and status.
        }

        /// <summary>
        /// Updates a line item's quantity and recomputes the entire cart.
        /// </summary>
        /// <param name="lineNumber">Line Number being updated</param>
        /// <param name="quantity">Updated/New quantity</param>
        /// <returns>Updated shopping cart</returns>
        void UpdateItemAsync(
            int lineNumber, 
            int quantity) {
            // performs some validation logic (like quantity < maximum quantity for example)
            // finds the ShoppingCartItem in the collection with the lineNumber index
            // re-evaluates totals and status.
        }

        /// <summary>
        /// Removes a line item from the cart and recomputes the entire cart.
        /// </summary>
        /// <param name="lineNumber">Line item to remove from the cart</param>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        void RemoveItemAsync(
            int lineNumber) {
            // performs some validation logic (other lines may need to be removed if this one is removed???)
            // removes the ShoppingCartItem in the collection with the lineNumber index
            // re-evaluates totals and status.
        }

        /// <summary>
        /// Links a customer to a shopping cart and recomputes the entire cart.
        /// This is happening when a guest logsin and identifies himself as a user/customer.
        /// </summary>
        /// <param name="customerId">Current customer's id (could be primary email)</param>
        /// <returns>Updated shopping cart</returns>
        void LinkCustomerAsync(
            string customerId) {
            // fetches the customer from an injected customer service??? and attach the customer to the shopping cart
            // re-evaluates totals and status.
        }

    }
}

using DDDTraining.ECommerce.SharedModels;
using DDDTraining.Transactions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTraining.Transactions.Services
{
    /// <summary>
    /// Shopping Cart Service responsible for all core operations on the shopping cart
    /// <list type="bullet">
    /// <item>
    /// <term>AddItemAsync</term>
    /// <description>Adds an item to the cart</description>
    /// </item>
    /// <item>
    /// <term>UpdateItemAsync</term>
    /// <description>Adds an item to the cart</description>
    /// </item>
    /// <item>
    /// <term>RemoveItemAsync</term>
    /// <description>Removes an item to the cart</description>
    /// </item>
    /// <item>
    /// <term>LinkCustomerAsync</term>
    /// <description>Link a customer to an existing shopping cart</description>
    /// </item>
    /// <item>    
    /// <term>EvaluateCartAsync</term>
    /// <description>Re-computes the cart prices</description>
    /// </item>      
    /// </list>
    /// </summary>
    public interface IShoppingCartService
    {
        /// <summary>
        /// Adds an item to the cart and recomputes the entire cart.
        /// </summary>
        /// <param name="sku">Product SKU to be added to the cart</param>
        /// <param name="quantity">Quantity being purchased</param>
        /// <returns>Updated shopping cart</returns>
        Task AddItemAsync(
            int sku, 
            int quantity, 
            DDDTraining.Transactions.Models.ShoppingCart cart);

        /// <summary>
        /// Updates a line item's quantity and recomputes the entire cart.
        /// </summary>
        /// <param name="lineNumber">Line Number being updated</param>
        /// <param name="quantity">Updated/New quantity</param>
        /// <returns>Updated shopping cart</returns>
        Task UpdateItemAsync(
            int lineNumber, 
            int quantity, 
            DDDTraining.Transactions.Models.ShoppingCart cart);

        /// <summary>
        /// Removes a line item from the cart and recomputes the entire cart.
        /// </summary>
        /// <param name="lineNumber">Line item to remove from the cart</param>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        Task RemoveItemAsync(
            int lineNumber, 
            DDDTraining.Transactions.Models.ShoppingCart cart);

        /// <summary>
        /// Links a customer to a shopping cart and recomputes the entire cart.
        /// This is happening when a guest logsin and identifies himself as a user/customer.
        /// </summary>
        /// <param name="customerId">Current customer's id (could be primary email)</param>
        /// <returns>Updated shopping cart</returns>
        Task LinkCustomerAsync(
            string customerId, 
            DDDTraining.Transactions.Models.ShoppingCart cart);

        /// <summary>
        /// Reevaluates the cart.
        /// </summary>
        /// <param name="cart">Shopping cart being checked out</param>
        /// <returns>Updated shopping cart</returns>
        Task EvaluateCartAsync(
            DDDTraining.Transactions.Models.ShoppingCart cart);
    }
}

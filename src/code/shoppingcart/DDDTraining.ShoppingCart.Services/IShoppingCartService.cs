using DDDTraining.ShoppingCart.Models;
using System.Threading.Tasks;

namespace DDDTraining.ShoppingCart.Services
{
    /// <summary>
    /// Shopping Cart Service responsible for all core operations on the shopping cart
    /// <list type="bullet">
    /// <item>
    /// <term>AddItem</term>
    /// <description>Adds an item to the cart</description>
    /// </item>
    /// <item>
    /// <term>UpdateItem</term>
    /// <description>Adds an item to the cart</description>
    /// </item>
    /// <item>
    /// <term>RemoveItem</term>
    /// <description>Removes an item to the cart</description>
    /// </item>
    /// <item>
    /// <term>CheckOut</term>
    /// <description>Proceed with Cart Checkout</description>
    /// </item>
    /// <item>    
    /// <term>ApplyPayment</term>
    /// <description>Applies a payment/method to the cart</description>
    /// </item>
    /// <item>
    /// <term>LinkCustomer</term>
    /// <description>Links a signed in customer with the shopping cart</description>
    /// </item>
    /// <item>
    /// <term>CompletePurchase</term>
    /// <description>Finalizes the purchases and moves the cart to a status of realized</description>
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
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> AddItemAsync(int sku, int quantity, DDDTraining.ShoppingCart.Models.ShoppingCart cart);

        /// <summary>
        /// Updates a line item's quantity and recomputes the entire cart.
        /// </summary>
        /// <param name="lineNumber">Line Number being updated</param>
        /// <param name="quantity">Updated/New quantity</param>
        /// <returns>Updated shopping cart</returns>
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> UpdateItemAsync(int lineNumber, int quantity, DDDTraining.ShoppingCart.Models.ShoppingCart cart);

        /// <summary>
        /// Removes a line item from the cart and recomputes the entire cart.
        /// </summary>
        /// <param name="lineNumber">Line item to remove from the cart</param>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> RemoveItemAsync(int lineNumber, DDDTraining.ShoppingCart.Models.ShoppingCart cart);

        /// <summary>
        /// Links a customer to a shopping cart and recomputes the entire cart.
        /// </summary>
        /// <param name="customerId">Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> LinkCustomerAsync(string customerId, DDDTraining.ShoppingCart.Models.ShoppingCart cart);

        /// <summary>
        /// Proceeds with cart checkout.
        /// </summary>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> CheckOutAsync(DDDTraining.ShoppingCart.Models.ShoppingCart cart);

        /// <summary>
        /// Applies a payment to the cart and recomputes Amount Due.
        /// </summary>
        /// <param name="customerId">Current customer's shopping cart</param>
        /// <param name="payment">A payment being applied against the cart</param>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> ApplyPaymentAsync(string customerId, ShoppingCartPayment payment, DDDTraining.ShoppingCart.Models.ShoppingCart cart);

        /// <summary>
        /// Completes the purchases of the shopping cart and moves the cart to a status of Realized.
        /// </summary>
        /// <param name = "cart" >Current customer's shopping cart</param>
        /// <returns>Updated shopping cart</returns>
        Task<DDDTraining.ShoppingCart.Models.ShoppingCart> CompletePurchaseAsync(DDDTraining.ShoppingCart.Models.ShoppingCart cart);
    }
}

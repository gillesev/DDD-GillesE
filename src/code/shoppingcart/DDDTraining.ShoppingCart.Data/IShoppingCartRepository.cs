using System.Threading.Tasks;

namespace DDDTraining.ShoppingCart.Data
{
    /// <summary>
    /// Shopping Cart domain repository responsible for persisting a customer's shopping cart
    /// during its various life time events.
    /// </summary>
    public interface IShoppingCartRepository
    {
        /// <summary>
        /// Saves a cart identified by its unique Id.
        /// </summary>
        /// <param name="cart">current shopping cart to be saved</param>
        Task SaveCartAsync(DDDTraining.ShoppingCart.Models.ShoppingCart cart, int status);

        /// <summary>
        /// Checks out a shopping cart (sets the cart in a status that will prevent to modify its items but not its price.)
        /// </summary>
        /// <param name="id">current shopping cart's unique Id</param>
        Task CheckoutCartAsync(string id);


        /// <summary>
        /// Completes the purchase of the shopping cart's items
        /// </summary>
        /// <param name="id">current shopping cart's unique Id</param>
        Task CompletePurchaseAsync(string id);
    }
}

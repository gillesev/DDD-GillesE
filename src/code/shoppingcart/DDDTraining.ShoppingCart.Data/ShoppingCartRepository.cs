using System;
using System.Threading.Tasks;

namespace DDDTraining.ShoppingCart.Data
{
    public class ShoppingCartRepository: IShoppingCartRepository
    {
        private readonly ShoppingCartUoW _uow;

        public ShoppingCartRepository(ShoppingCartUoW uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// Saves a cart identified by its unique Id.
        /// </summary>
        /// <param name="cart">current shopping cart to be saved</param>
        public async Task SaveCartAsync(DDDTraining.ShoppingCart.Models.ShoppingCart cart, int status)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks out a shopping cart (sets the cart in a status that will prevent to modify its items but not its price.)
        /// </summary>
        /// <param name="id">current shopping cart's unique Id</param>
        public async Task CheckoutCartAsync(string id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Completes the purchase of the shopping cart's items
        /// </summary>
        /// <param name="id">current shopping cart's unique Id</param>
        public async Task CompletePurchaseAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}

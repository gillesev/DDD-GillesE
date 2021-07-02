using DDDTraining.ECommerce.SharedModels;
using DDDTraining.Transactions.Models;
using DDDTraining.Transactions.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTraining.Transactions.APIs
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ILogger<ShoppingCartController> _logger;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IOrderTransactionService _orderTransactionService;

        public ShoppingCartController(
            ILogger<ShoppingCartController> logger,
            IShoppingCartService shoppingCartService,
            IOrderTransactionService orderTransactionService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
            _orderTransactionService = orderTransactionService;
        }

        /// <summary>
        /// Upsert items in a shopping cart
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/adjustments")]
        public async Task<IActionResult> UpsertCartAsync([FromBody] CartUpdateRequestDTO request)
        {
            // STEP 1: will find the cart in backend storage (like REDIS/DynamoDB) based on session id token for example.
            // get the cart's id.
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string cartId = "1addd-cccc-wewee-ffdjljl112";
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            // STEP 2: re-ify the cart's ShoppingCart domain object.
            ShoppingCart cart = new ShoppingCart(); // from cartId

            // STEP 3: and translates the request's DTO object into Shopping cart's Item objects to be added/updated/removed.
            // and fetch product information from productcatalog to obtain prices.
            // based on adjustments, call AddItemAsync/RemoveItemAsync/UpdateItemAsync
            // sample code below:
            int sku = 564352637;
            int qty = 2;
            await this._shoppingCartService.AddItemAsync(sku, qty, cart);
            int lineNumber = 3;
            await this._shoppingCartService.RemoveItemAsync(lineNumber, cart);

            // STEP 4: re-evaluate the cart: call EvaluateCartAsync
            await this._shoppingCartService.EvaluateCartAsync(cart);

            // STEP 5
            // saves the cart using a repository pattern (NOT DONE).

            // IF new return Created (201) or NoContent (204) but out of scope.
            return Ok();
        }

        /// <summary>
        /// Upsert items in a shopping cart and proceed to checkout.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPatch]
        [Route("/checkout/current")]
        public async Task<IActionResult> UpdateCartForCheckoutAsync([FromBody] CartCheckoutRequestDTO request)
        {
            // STEP 1
            // will find the cart in backend storage (like REDIS/DynamoDB) based on session id token for example.
            // get the cart's id.
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string cartId = "1addd-cccc-wewee-ffdjljl112";
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            // STEP 2
            // re-ify the cart's ShoppingCart domain object.
            // and translates the request's DTO object into Shopping cart's Item objects to be added/updated/removed.
            // and fetch product information from productcatalog to obtain prices.
            // based on adjustments, call AddItemAsync/RemoveItemAsync/UpdateItemAsync
            ShoppingCart cart = new ShoppingCart();

            // STEP 3: like is done for UpsertCartAsync (code to be factored out) eventually,
            // re-evaluate the cart: call EvaluateCartAsync
            await this._shoppingCartService.EvaluateCartAsync(cart);

            // STEP 5: use anti-corruption layer to translate the CartCheckoutRequestDTO request into the domain objects
            // to compute an order details = final prices (w/o customer discounts), shipping fees, taxes.
            // IF these are not in the CartUpdateRequestDTO request, need to:
            // - fetch customer info for default shipping address on file
            // - fetch customer payment methods = CC token on File, Gift Card, Points ETC...
            var shippingAddress = new PostalAddress();
            IList<ShippingOptions> shippingOptions = new List<ShippingOptions>();
            IList<PaymentMethodAllocation> paymentAllocations = new List<PaymentMethodAllocation>();

            // note that the order is throw away but it used to update what we save in the shopping cart.
            var order = await this._orderTransactionService.ComputeOrderDetailsAsync(
                cart,
                shippingAddress,
                shippingOptions,
                paymentAllocations);

            // STEP 6, saves the shopping cart with Updated totals, Estimated Taxes and Customer information.

            // Ok or NoContent (204) but out of scope.
            return Ok();
        }

        /// <summary>
        /// Upsert items in a shopping cart
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/current")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> GetCurrentCartAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            // STEP 1: will find the cart in backend storage (like REDIS/DynamoDB) based on session id token for example.
            // get the cart's id.
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string cartId = "1addd-cccc-wewee-ffdjljl112";
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            // STEP 2: re-ify the cart's ShoppingCart domain object.
            ShoppingCart cart = new ShoppingCart(); // from cartId

            // STEP 3: use Anti-Corruption layer to translate the ShoppingCart domain object into a DTO.
            var cartDTO = new CartDTO();

            return Ok(cartDTO);
        }
    }
}

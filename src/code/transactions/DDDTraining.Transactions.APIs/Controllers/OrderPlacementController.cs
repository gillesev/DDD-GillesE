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
    public class OrderPlacementController : ControllerBase
    {
        private readonly ILogger<OrderPlacementController> _logger;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IOrderTransactionService _orderTransactionService;

        public OrderPlacementController(
            ILogger<OrderPlacementController> logger,
            IShoppingCartService shoppingCartService,
            IOrderTransactionService orderTransactionService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
            _orderTransactionService = orderTransactionService;
        }

        /// <summary>
        /// Places an order.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/orders")]
        public async Task<IActionResult> PlaceOrderAsync([FromBody] CartUpdateRequestDTO request)
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

            // STEP 5: use anti-corruption layer to translate the CartUpdateRequestDTO request into the domain objects
            // to compute an order details = final prices (w/o customer discounts), shipping fees, taxes.
            // IF these are not in the CartUpdateRequestDTO request, need to:
            // - fetch customer info for default shipping address on file
            // - fetch customer payment methods = CC token on File, Gift Card, Points ETC...
            var shippingAddress = new PostalAddress();
            IList<ShippingOptions> shippingOptions = new List<ShippingOptions>();
            IList<PaymentMethodAllocation> paymentAllocations = new List<PaymentMethodAllocation>();

            var order = await this._orderTransactionService.PlaceOrderAsync(
                cart,
                shippingAddress,
                shippingOptions,
                paymentAllocations);

            // STEP 6, saves the retail order sale with Updated totals, Estimated Taxes and Customer information (NOT DONE)
            // return CreatedAtAction = 201 (NOT DONE)
            return Ok();
        }

        /// <summary>
        /// Places an order.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/orders/{orderNumber}")]
        public async Task<IActionResult> CancelOrderAsync([FromQuery] string orderNumber)
        {
            // STEP 1
            // re-ify the order from order number.
            RetailOrder order = new RetailOrder();

            // STEP 2
            _ = await this._orderTransactionService.RequestOrderCancelAsync(
                order);

            // STEP 6, saves the shopping cart with Updated totals, Estimated Taxes and Customer information.
            return Accepted();
        }
    }
}

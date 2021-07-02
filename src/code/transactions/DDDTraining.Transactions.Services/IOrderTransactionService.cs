using DDDTraining.ECommerce.SharedModels;
using DDDTraining.Transactions.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTraining.Transactions.Services
{
    /// <summary>
    /// Order Transaction Service responsible for computing the order details and placing the order
    /// <list type="bullet">
    /// <item>
    /// <term>ComputeOrderDetailsAsync</term>
    /// <description>Recompute a cart's final prices, shipping fees and taxes</description>
    /// </item>
    /// <item>
    /// <item>
    /// <term>PlaceOrderAsync</term>
    /// <description>Processes payment, places the order and send customer notifications</description>
    /// </item>
    /// <item>
    /// <term>RequestCancelOrderAsync</term>
    /// <description>Request an order to be cancelled.</description>
    /// </item>    
    /// </list>
    /// </summary>
    public interface IOrderTransactionService
    {
        /// <summary>
        /// Computes all order details: shipping fees, customer discounts, taxes and final price.
        /// </summary>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <param name="shippingAddress">Shipping Address (primary) where products need to be shipped</param>
        /// <param name="shippingOptions">List of shipping delivery options elected by the customer</param>
        /// <param name="paymentAllocations">List of payment Methods with their associated amounts</param>
        /// <returns>Final order to be confirmed by the customer</returns>
        Task<DDDTraining.Transactions.Models.RetailOrder> ComputeOrderDetailsAsync(
            DDDTraining.Transactions.Models.ShoppingCart cart,
            PostalAddress shippingAddress,
            IList<ShippingOptions> shippingOptions,
            IList<PaymentMethodAllocation> paymentAllocations);


        /// <summary>
        /// - re-computes all order details and runs validation rules
        /// - orchestrate payments processing 
        /// e.g. It will publish some event messages for the Payment Gateway domain
        /// - IF all payments are OK, save the order in the backend and publish a OrderPaidEvent.
        /// that the OrderFulfillment and CustomerHistory domains listen to.
        /// </summary>
        /// <param name="cart">Current customer's shopping cart</param>
        /// <param name="shippingAddress">Shipping Address (primary) where products need to be shipped</param>
        /// <param name="shippingOptions">List of shipping delivery options elected by the customer</param>
        /// <param name="paymentAllocations">List of payment Methods with their associated amounts</param>
        /// <returns>Final order to be confirmed by the customer</returns>
        Task<DDDTraining.Transactions.Models.RetailOrder> PlaceOrderAsync(
            DDDTraining.Transactions.Models.ShoppingCart cart,
            PostalAddress shippingAddress,
            IList<ShippingOptions> shippingOptions,
            IList<PaymentMethodAllocation> paymentAllocations); 

        /// <summary>
        /// Requests an order to be cancelled.
        /// </summary>
        /// <param name="order">The order to cancel</param>
        /// <returns>A Cancelled order</returns>
        Task<DDDTraining.Transactions.Models.RetailOrder> RequestOrderCancelAsync(
            DDDTraining.Transactions.Models.RetailOrder order);                    
    }
}

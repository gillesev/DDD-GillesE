using DDDTraining.OrderFulfillment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTraining.OrderFulFillment.Services
{
    /// <summary>
    /// Order Fulfillment Service responsible for sourcing the products from distribution centers.
    /// <list type="bullet">
    /// <item>
    /// <term>SourceAsync</term>
    /// <description>Creates 1 to N sourcing orders from 1 customer order.</description>
    /// </item>
    /// <item>
    /// <item>
    /// <term>CancelSourcingOrderAsync</term>
    /// <description>Cancels 1 sourcing order.</description>
    /// </item>
    /// <item>
    /// <term>CancelCustomerOrderSourcingAsync</term>
    /// <description>Cancels associated all sourcing orders corresponding to 1 customer order.</description>
    /// </item>    
    /// </list>
    /// </summary>
    public interface IOrderFulfillmentService
    {
        Task<ICollection<SourcingOrder>> SourceAsync(CustomerOrder customerOrder);

        Task CancelSourcingOrderAsync(SourcingOrder sourcingOrder);

        Task CancelCustomerOrderSourcingAsync(CustomerOrder customerOrder);
    }
}

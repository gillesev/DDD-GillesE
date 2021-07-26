using DDDTraining.ECommerce.SharedModels;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace DDDTraining.OrderFulfillment.BackEnd.APIs
{
    /// <summary>
    /// Function responsible for sourcing a new customer order.
    /// and create the associated sourcing orders (1 to N) based on:
    /// - Distribution Center Inventory
    /// - Delivery constraints: delivery Location(s) and delivery due date(s)
    /// </summary>
    public static class OrderFulfillmentProcessor
    {
        /// <summary>
        /// Function responsible for processing a new/paid order
        /// and create the appropriate shippments applying all country/state regulations and shipping time constraints.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="log"></param>
        [FunctionName(nameof(FulfillOrder))]
        public static void FulfillOrder(
            [QueueTrigger("paid-orders", Connection = "")] IOrderPaidEvent item, 
            ILogger log)
        {
            log.LogInformation($"Will process the new paid order: {item.OrderNumber} to create N shippments.");
        }
    }
}

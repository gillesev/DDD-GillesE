using DDDTraining.ECommerce.SharedModels;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace DDDTraining.OrderShipping.BackEnd.APIs
{
    /// <summary>
    /// Function responsible for processing sourced orders and create associated 1 to N shipments.
    /// </summary>
    public static class SourcedOrdersProcessor
    {
        /// <summary>
        /// Function responsible for processing a new/paid order
        /// and create the appropriate shippments applying all country/state regulations and shipping time constraints.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="log"></param>
        [FunctionName(nameof(ProcessSourcedOrder))]
        public static void ProcessSourcedOrder(
            [QueueTrigger("paid-orders", Connection = "")] IOrderSourcedEvent item, 
            ILogger log)
        {
            log.LogInformation($"Will process the new sourced order: {item.OrderNumber} from customer order: {item.CustomerOrderNumber} to create N shippments.");
        }
    }
}

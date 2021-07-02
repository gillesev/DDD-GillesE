using DDDTraining.ECommerce.SharedModels;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace DDDTraining.Transactions.BackEnd.APIs
{
    /// <summary>
    /// Function to listen to payment response events.
    /// Will coordinate with Order Placement API.
    /// </summary>
    public static class PaymentAuthorizationProcessor
    {
        [FunctionName(nameof(ProcessAuthorization))]
        public static void ProcessAuthorization(
            [QueueTrigger("payment-authorization-responses", Connection = "")] IPaymentResponseEvent item, 
            ILogger log)
        {
            log.LogInformation($"Will process the payment authorization response: {item} to finalize order using {item.RequestId}.");
        }
    }
}

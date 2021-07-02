using DDDTraining.PaymentGateway.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace DDDTraining.PaymentGateway.APIs
{
    public static class PaymentAuthorizationProcessor
    {
        /// <summary>
        /// Responsible for processing any type of payment authorization (authorization, reversals, voids) accross any payment method.
        /// This design is simplistic as it assumes only 1 sub system is interested in the authorization response. A topic pub/sub design
        /// may be more realistic.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="log"></param>
        [FunctionName(nameof(ProcessAuthorization))]
        public static void ProcessAuthorization(
            [QueueTrigger("payment-authorization-requests", Connection = "")] AuthorizationRequestEvent item, 
            ILogger log)
        {
            log.LogInformation($"Will process the authorization of this payment request: {item} and drop a payment response event in another queue.");
        }
    }
}

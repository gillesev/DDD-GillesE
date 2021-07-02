using DDDTraining.PaymentGateway.Models;
using System.Threading.Tasks;

namespace DDDTraining.PaymentGateway.Services
{
    /// <summary>
    /// Shopping Cart Service responsible for all core operations on the shopping cart
    /// <list type="bullet">
    /// <item>
    /// <term>AuthorizeAsync</term>
    /// <description>Authorizes a payment request</description>
    /// </item>
    /// <item>
    /// <term>ReverseAsync</term>
    /// <description>Reverses a timed out/errored request</description>
    /// </item>    
    /// <item>
    /// <term>VoidAsync</term>
    /// <description>Voids a payment request with an approved response</description>
    /// </item>    
    /// </list>
    /// </summary>
    public interface IPaymentService
    {
        /// <summary>
        /// Authorizes a payment request
        /// </summary>
        /// <param name="request">request to be authorized</param>
        /// <returns>Autorization response</returns>
        Task<PaymentResponse> AuthorizeAsync(
            AuthorizationRequest request);
        
        /// <summary>
        /// Reverses a payment request. Used for Timeout reversals.
        /// </summary>
        /// <param name="request">request to be reversed</param>
        /// <returns>Autorization response</returns>
        Task<PaymentResponse> ReverseAsync(
            AuthorizationRequest request);

        /// <summary>
        /// Voids an approved payment request
        /// </summary>
        /// <param name="request">request to be voided</param>
        /// <param name="response">corresponding request's response for validation</param>
        /// <returns>Autorization response</returns>
        Task<PaymentResponse> VoidAsync(
            AuthorizationRequest request, PaymentResponse response);
    }
}
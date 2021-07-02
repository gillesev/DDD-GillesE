using DDDTraining.Transactions.Models;
using System.Collections.Generic;

namespace DDDTraining.Transactions.APIs
{
    /// <summary>
    /// Represents a request to checkout the cart
    /// </summary>
    /// <example>
    /// Add 3 bottles of Acetominophen
    /// Update line # 2 quantity to 2.
    /// </example>
    public class CartCheckoutRequestDTO
    {
        /// <summary>
        /// Represents a set of Adjustments made to the cart.
        /// </summary>
        public IList<CartItemAdjustmentDTO> Adjustments { get; set; }

        /// <summary>
        /// Represents a set of Adjustments made to the shipping options.
        /// </summary>
        public IList<ShippingOptionsDTO> ShippingOptions { get; set; }

        /// <summary>
        /// Represents a set of Adjustments made to the payment allocations.
        /// This model assumes the payment method DTO object only references a payment method id.
        /// </summary>
        public IList<PaymentMethodAllocationDTO> PaymentAllocations { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDTraining.Transactions.APIs
{
    /// <summary>
    /// Represents a set of adjustments made to the shopping cart
    /// </summary>
    /// <example>
    /// Add 3 bottles of Acetominophen
    /// Update line # 2 quantity to 2.
    /// </example>
    public class CartUpdateRequestDTO
    {
        /// <summary>
        /// Represents a set of Adjustments made to the cart.
        /// UI is sending changes (JSON PATCH???)
        /// </summary>
        public List<CartItemAdjustmentDTO> Adjustments { get; set; }
    }
}

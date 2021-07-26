using System.Collections.Generic;

namespace DDDTraining.Transactions.APIs
{
    /// <summary>
    /// Represents a shopping cart exposed to the outside world
    /// </summary>
    public class CartDTO
    {
        /// <summary>
        /// List of Product items added to the cart
        /// The list might be empty.
        /// </summary>
        public List<CartItemDTO> Items { get; set; }

        /// <summary>
        /// Cart's total amount before taxes
        /// </summary>
        public decimal GrossTotalAmount { get; set; }

        /// <summary>
        /// Estimated taxes. Not calculated until the cart is checked out.
        /// </summary>
        public decimal EstimatedTaxes { get; set; }

        /// <summary>
        /// Cart's total amount including taxes
        /// </summary>
        public decimal NetTotalAmount { get; set; }
    }
}

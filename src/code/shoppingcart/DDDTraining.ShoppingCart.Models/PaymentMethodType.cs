namespace DDDTraining.ShoppingCart.Models
{
    /// <summary>
    /// Payment Method Type
    /// </summary>
    /// <example>
    /// GiftCard
    /// </example>
    public class PaymentMethodType
    {
        /// <summary>
        /// Represents a Credit Card such as VISA, Master Card, Dinner's Club ETC...
        /// </summary>
        public const int CreditCard = 1;
        /// <summary>
        /// Represents a Debit Card
        /// </summary>
        public const int DebitCard = 2;
        /// <summary>
        /// Represents a Retailer Issued Credit Card
        /// </summary>
        public const int PrivateLabel = 3;
        /// <summary>
        /// Represents a Retailer Issued Gift Card
        /// </summary>
        public const int GiftCard = 4;
    }
}
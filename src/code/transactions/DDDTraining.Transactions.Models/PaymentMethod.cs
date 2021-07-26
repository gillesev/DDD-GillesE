namespace DDDTraining.Transactions.Models
{
    /// <summary>
    /// Represents a Customer Payment Method
    /// </summary>
    /// <example>
    /// Retailer XYZ Points
    /// </example>
    /// <example>
    /// Gift Card 24164135674563
    /// </example>
    /// <example>
    /// Credit Card Token on File
    /// 4147********5001
    /// Gilles Eveloy
    /// Valid Thru 08/25
    /// </example>    
    public class PaymentMethod
    {
        /// <summary>
        /// Unique ID for this customer payment method.
        /// </summary>

        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Account Credit Card/Debit Card Token
        /// or 
        /// Gift Card # in clear
        /// We do not concern ourselves with PCI data sensitivity.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Represents the balance in points or Gift Card available balance.
        /// </summary>
        public decimal Balance {get; set;}

        /// <summary>
        /// Date when the method of payment expires
        /// </summary>
        /// <example>
        /// 0825
        /// </example>
        public string ValidThru { get; set; }

        /// <summary>
        /// Method Type such as Credit/Debut/GC/PrivateLabel
        /// This may drive Promotion qualification.
        /// NOTE: C# enum types are not easy to evolve and are not extensible.
        /// therefore preferred a class with constants.
        /// See PaymentMethodType class.
        /// </summary>
        /// <example>
        /// Credit
        /// </example>
        public int PaymentMethodType { get; set; }

        /// <summary>
        /// Represents a unique friendly name for the payment method
        /// </summary>
        /// <example>
        /// My Retailer's Name CC
        /// </example>        
        public string Nickname { get; set; }
    }
}
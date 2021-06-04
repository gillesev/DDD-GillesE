using System;

namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents a Postal Address.
    /// </summary>
    /// <example>
    /// 5001 Lyndale Avenue
    /// Minneapolis, MN 55408 - USA
    /// </example>
    public class PostalAddress
    {
        /// <summary>
        /// Address Line 1.
        /// </summary>
        /// <example>
        /// 5001 Lyndale Avenue
        /// </example>
        public string Line1 { get; set; }
        /// <summary>
        /// Address Line 2.
        /// </summary>
        /// <example>
        /// Suite ABC - Bloc X
        /// </example>
        public string Line2 { get; set; }
        /// <summary>
        /// Address Line 3.
        /// </summary>
        /// <example>
        /// Attn to: Mr John .Smith
        /// </example>
        public string Line3 { get; set; }
        /// <summary>
        /// Postal Code/ZipCode.
        /// </summary>
        /// <example>
        /// 55408
        /// </example>        
        /// <example>
        /// 55408-4200
        /// </example>        
        public string PostalCode { get; set; }
        /// <summary>
        /// City
        /// </summary>
        /// <example>
        /// Minneapolis
        /// </example>        
        public string City { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        /// <example>
        /// USA - will use an ISO Code 3166-1
        /// </example>        
        public int CountryCode { get; set; }
    }
}

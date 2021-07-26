using System;

namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents an event that happened at a given UTC date/time.
    /// </summary>
    public interface IAddressable
    {
        /// <summary>
        /// Address Line 1.
        /// </summary>
        /// <example>
        /// 5001 Lyndale Avenue
        /// </example>
        string Line1 { get; set; }
        /// <summary>
        /// Address Line 2.
        /// </summary>
        /// <example>
        /// Suite ABC - Bloc X
        /// </example>
        string Line2 { get; set; }
        /// <summary>
        /// Address Line 3.
        /// </summary>
        /// <example>
        /// Attn to: Mr John .Smith
        /// </example>
        string Line3 { get; set; }
        /// <summary>
        /// Postal Code/ZipCode.
        /// </summary>
        /// <example>
        /// 55408
        /// </example>        
        /// <example>
        /// 55408-4200
        /// </example>        
        string PostalCode { get; set; }
        /// <summary>
        /// City
        /// </summary>
        /// <example>
        /// Minneapolis
        /// </example>        
        string City { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        /// <example>
        /// USA - will use an ISO Code 3166-1
        /// </example>        
        int CountryCode { get; set; }
    }
}

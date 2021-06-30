using DDDTraining.ECommerce.SharedModels;
using System;
using System.Collections.Generic;

namespace DDDTraining.CustomerHistory.Models
{
    /// <summary>
    /// Represents a customer's purchase (immutable) as the result of an order having being transacted.
    /// </summary>
    public class RetailTransactionLog
    {
        /// <summary>
        /// Transaction Id.
        /// </summary>
        /// <example>
        /// 20210627129978945612
        /// </example>
        public string TransactionId {get; set;}

        /// <summary>
        /// Order Id that resulted in a Sale. May be NULL (if a return).
        /// </summary>
        /// <example>
        /// 1111-222333-4444-5556666
        /// </example>
        public string OrderId {get; set;}

        /// <summary>
        /// Category of transaction: Sale, Return, Exchange ETC...
        /// </summary>
        /// <example>
        /// 2: Return
        /// </example>
        public int TransactionType { get; set; }

        /// <summary>
        /// Retail POS Log contains the transactions details as far as:
        /// - item lines
        /// - item line discounts
        /// - taxes
        /// - customer
        /// - payments (Authorization Codes/GC Points ETC...)
        /// - Totals
        /// May be an XML Retail Industry format document.
        /// </summary>
        public string Log {get; set;}

        /// <summary>
        /// Timestamp at which the transaction was created.
        /// </summary>
        public DateTime UTCDateTimeCreated { get; set; }
    }
}

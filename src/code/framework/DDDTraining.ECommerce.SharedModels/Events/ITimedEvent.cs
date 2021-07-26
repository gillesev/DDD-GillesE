using System;

namespace DDDTraining.ECommerce.SharedModels
{
    /// <summary>
    /// Represents an event that happened at a given UTC date/time.
    /// </summary>
    public interface ITimedEvent
    {
        /// <summary>
        /// UTC time stamp when a request or response was created. Immutable.
        /// </summary>
        DateTime CreationUTCTimeStamp { get; set; }
    }
}

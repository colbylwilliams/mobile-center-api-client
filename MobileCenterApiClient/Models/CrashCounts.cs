// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MobileCenterApi.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class CrashCounts
    {
        /// <summary>
        /// Initializes a new instance of the CrashCounts class.
        /// </summary>
        public CrashCounts() { }

        /// <summary>
        /// Initializes a new instance of the CrashCounts class.
        /// </summary>
        public CrashCounts(long? count = default(long?), IList<DateTimeCounts> crashes = default(IList<DateTimeCounts>))
        {
            Count = count;
            Crashes = crashes;
        }

        /// <summary>
        /// total crash count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// the total crash count for day
        /// </summary>
        [JsonProperty(PropertyName = "crashes")]
        public IList<DateTimeCounts> Crashes { get; set; }

    }
}
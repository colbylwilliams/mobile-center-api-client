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

    public partial class EventCount
    {
        /// <summary>
        /// Initializes a new instance of the EventCount class.
        /// </summary>
        public EventCount() { }

        /// <summary>
        /// Initializes a new instance of the EventCount class.
        /// </summary>
        public EventCount(long? totalCount = default(long?), long? previousTotalCount = default(long?), IList<DateTimeCounts> count = default(IList<DateTimeCounts>))
        {
            TotalCount = totalCount;
            PreviousTotalCount = previousTotalCount;
            Count = count;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previous_total_count")]
        public long? PreviousTotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public IList<DateTimeCounts> Count { get; set; }

    }
}

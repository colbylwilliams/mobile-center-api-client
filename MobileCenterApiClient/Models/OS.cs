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

    public partial class OS
    {
        /// <summary>
        /// Initializes a new instance of the OS class.
        /// </summary>
        public OS() { }

        /// <summary>
        /// Initializes a new instance of the OS class.
        /// </summary>
        public OS(string osName = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            OsName = osName;
            Count = count;
            PreviousCount = previousCount;
        }

        /// <summary>
        /// OS name
        /// </summary>
        [JsonProperty(PropertyName = "os_name")]
        public string OsName { get; set; }

        /// <summary>
        /// count current of OS
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// count of previous OS
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

    }
}

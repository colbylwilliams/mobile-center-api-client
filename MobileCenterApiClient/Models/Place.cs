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

    /// <summary>
    /// The place code and the count
    /// </summary>
    public partial class Place
    {
        /// <summary>
        /// Initializes a new instance of the Place class.
        /// </summary>
        public Place() { }

        /// <summary>
        /// Initializes a new instance of the Place class.
        /// </summary>
        public Place(string code = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            Code = code;
            Count = count;
            PreviousCount = previousCount;
        }

        /// <summary>
        /// the place code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// the count of the this place
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// the count of previous time range of the place
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

    }
}

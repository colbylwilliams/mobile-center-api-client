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

    public partial class FeaturePatchRequest
    {
        /// <summary>
        /// Initializes a new instance of the FeaturePatchRequest class.
        /// </summary>
        public FeaturePatchRequest() { }

        /// <summary>
        /// Initializes a new instance of the FeaturePatchRequest class.
        /// </summary>
        public FeaturePatchRequest(string displayName = default(string), int? state = default(int?), string description = default(string))
        {
            DisplayName = displayName;
            State = state;
            Description = description;
        }

        /// <summary>
        /// The full (friendly) name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The state of the feature
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// The friendly name of the feature
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}

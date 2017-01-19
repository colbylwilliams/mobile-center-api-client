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
    /// A response containing information about the uploaded release.
    /// </summary>
    public partial class ReleaseUploadEndResponse
    {
        /// <summary>
        /// Initializes a new instance of the ReleaseUploadEndResponse class.
        /// </summary>
        public ReleaseUploadEndResponse() { }

        /// <summary>
        /// Initializes a new instance of the ReleaseUploadEndResponse class.
        /// </summary>
        public ReleaseUploadEndResponse(string releaseUrl = default(string))
        {
            ReleaseUrl = releaseUrl;
        }

        /// <summary>
        /// A URL to the new release. If upload was aborted will be null.
        /// </summary>
        [JsonProperty(PropertyName = "release_url")]
        public string ReleaseUrl { get; set; }

    }
}

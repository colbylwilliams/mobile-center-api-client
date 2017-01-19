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
    /// Result of uploading a single file hash
    /// </summary>
    public partial class TestCloudHashUploadStatus
    {
        /// <summary>
        /// Initializes a new instance of the TestCloudHashUploadStatus class.
        /// </summary>
        public TestCloudHashUploadStatus() { }

        /// <summary>
        /// Initializes a new instance of the TestCloudHashUploadStatus class.
        /// </summary>
        public TestCloudHashUploadStatus(double statusCode, string location = default(string))
        {
            StatusCode = statusCode;
            Location = location;
        }

        /// <summary>
        /// HTTP status code that represent result of upload
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public double StatusCode { get; set; }

        /// <summary>
        /// URI that should be used to make POST request if file with given
        /// hash doesn't exist. This is set when status_code is equal to 412
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
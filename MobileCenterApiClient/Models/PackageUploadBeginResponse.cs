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
    /// A response containing information pertaining to starting a package
    /// upload process
    /// </summary>
    public partial class PackageUploadBeginResponse
    {
        /// <summary>
        /// Initializes a new instance of the PackageUploadBeginResponse class.
        /// </summary>
        public PackageUploadBeginResponse() { }

        /// <summary>
        /// Initializes a new instance of the PackageUploadBeginResponse class.
        /// </summary>
        public PackageUploadBeginResponse(string uploadId, string uploadUrl)
        {
            UploadId = uploadId;
            UploadUrl = uploadUrl;
        }

        /// <summary>
        /// The ID for the current upload
        /// </summary>
        [JsonProperty(PropertyName = "upload_id")]
        public string UploadId { get; set; }

        /// <summary>
        /// The URL where the client needs to upload the package to
        /// </summary>
        [JsonProperty(PropertyName = "upload_url")]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (UploadId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UploadId");
            }
            if (UploadUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UploadUrl");
            }
        }
    }
}

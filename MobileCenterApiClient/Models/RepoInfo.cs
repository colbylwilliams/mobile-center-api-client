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

    public partial class RepoInfo
    {
        /// <summary>
        /// Initializes a new instance of the RepoInfo class.
        /// </summary>
        public RepoInfo() { }

        /// <summary>
        /// Initializes a new instance of the RepoInfo class.
        /// </summary>
        public RepoInfo(string repoUrl)
        {
            RepoUrl = repoUrl;
        }

        /// <summary>
        /// The repository url
        /// </summary>
        [JsonProperty(PropertyName = "repo_url")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (RepoUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RepoUrl");
            }
        }
    }
}
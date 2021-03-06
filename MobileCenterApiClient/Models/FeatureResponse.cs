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

    public partial class FeatureResponse
    {
        /// <summary>
        /// Initializes a new instance of the FeatureResponse class.
        /// </summary>
        public FeatureResponse() { }

        /// <summary>
        /// Initializes a new instance of the FeatureResponse class.
        /// </summary>
        public FeatureResponse(string name, string displayName, int state, string description = default(string))
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            State = state;
        }

        /// <summary>
        /// The unique name of the feature
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The friendly name of the feature
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the feature
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The state (unset, enabled, disabled) of the feature
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int State { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
        }
    }
}

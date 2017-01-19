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

    public partial class Branch
    {
        /// <summary>
        /// Initializes a new instance of the Branch class.
        /// </summary>
        public Branch() { }

        /// <summary>
        /// Initializes a new instance of the Branch class.
        /// </summary>
        public Branch(string name, Commit commit)
        {
            Name = name;
            Commit = commit;
        }

        /// <summary>
        /// The branch name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public Commit Commit { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Commit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Commit");
            }
        }
    }
}

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

    public partial class CrashGroupChange
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupChange class.
        /// </summary>
        public CrashGroupChange() { }

        /// <summary>
        /// Initializes a new instance of the CrashGroupChange class.
        /// </summary>
        public CrashGroupChange(object status = default(object))
        {
            Status = status;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public object Status { get; set; }

    }
}

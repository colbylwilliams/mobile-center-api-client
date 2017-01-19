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

    public partial class CrashGroupOperatingSystems
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupOperatingSystems class.
        /// </summary>
        public CrashGroupOperatingSystems() { }

        /// <summary>
        /// Initializes a new instance of the CrashGroupOperatingSystems class.
        /// </summary>
        public CrashGroupOperatingSystems(long? crashCount = default(long?), IList<CrashGroupOperatingSystem> operatingSystems = default(IList<CrashGroupOperatingSystem>))
        {
            CrashCount = crashCount;
            OperatingSystems = operatingSystems;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operating_systems")]
        public IList<CrashGroupOperatingSystem> OperatingSystems { get; set; }

    }
}

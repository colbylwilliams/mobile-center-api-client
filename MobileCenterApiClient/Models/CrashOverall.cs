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

    public partial class CrashOverall
    {
        /// <summary>
        /// Initializes a new instance of the CrashOverall class.
        /// </summary>
        public CrashOverall() { }

        /// <summary>
        /// Initializes a new instance of the CrashOverall class.
        /// </summary>
        public CrashOverall(long? crashCount = default(long?), long? deviceCount = default(long?))
        {
            CrashCount = crashCount;
            DeviceCount = deviceCount;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_count")]
        public long? DeviceCount { get; set; }

    }
}

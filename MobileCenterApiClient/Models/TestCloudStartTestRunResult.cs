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
    /// Result of starting a test run
    /// </summary>
    public partial class TestCloudStartTestRunResult
    {
        /// <summary>
        /// Initializes a new instance of the TestCloudStartTestRunResult
        /// class.
        /// </summary>
        public TestCloudStartTestRunResult() { }

        /// <summary>
        /// Initializes a new instance of the TestCloudStartTestRunResult
        /// class.
        /// </summary>
        public TestCloudStartTestRunResult(IList<string> acceptedDevices = default(IList<string>), IList<string> rejectedDevices = default(IList<string>))
        {
            AcceptedDevices = acceptedDevices;
            RejectedDevices = rejectedDevices;
        }

        /// <summary>
        /// List with names of accepted devices
        /// </summary>
        [JsonProperty(PropertyName = "accepted_devices")]
        public IList<string> AcceptedDevices { get; set; }

        /// <summary>
        /// List with names and descriptions of rejected devices
        /// </summary>
        [JsonProperty(PropertyName = "rejected_devices")]
        public IList<string> RejectedDevices { get; set; }

    }
}

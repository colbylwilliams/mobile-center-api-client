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
    /// Current status of a test run
    /// </summary>
    public partial class TestRunState
    {
        /// <summary>
        /// Initializes a new instance of the TestRunState class.
        /// </summary>
        public TestRunState() { }

        /// <summary>
        /// Initializes a new instance of the TestRunState class.
        /// </summary>
        public TestRunState(IList<string> message = default(IList<string>), int? waitTime = default(int?), int? exitCode = default(int?))
        {
            Message = message;
            WaitTime = waitTime;
            ExitCode = exitCode;
        }

        /// <summary>
        /// Multi-line message that describes the status
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public IList<string> Message { get; set; }

        /// <summary>
        /// Time (in seconds) that the client should wait for before checking
        /// the status again
        /// </summary>
        [JsonProperty(PropertyName = "wait_time")]
        public int? WaitTime { get; set; }

        /// <summary>
        /// Exit code for the client
        /// </summary>
        [JsonProperty(PropertyName = "exit_code")]
        public int? ExitCode { get; set; }

    }
}

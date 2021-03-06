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

    public partial class TestReportDeviceLogsItem
    {
        /// <summary>
        /// Initializes a new instance of the TestReportDeviceLogsItem class.
        /// </summary>
        public TestReportDeviceLogsItem() { }

        /// <summary>
        /// Initializes a new instance of the TestReportDeviceLogsItem class.
        /// </summary>
        public TestReportDeviceLogsItem(string deviceSnapshotId = default(string), string deviceLog = default(string), string testLog = default(string), string appiumLog = default(string))
        {
            DeviceSnapshotId = deviceSnapshotId;
            DeviceLog = deviceLog;
            TestLog = testLog;
            AppiumLog = appiumLog;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_snapshot_id")]
        public string DeviceSnapshotId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_log")]
        public string DeviceLog { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "test_log")]
        public string TestLog { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appium_log")]
        public string AppiumLog { get; set; }

    }
}

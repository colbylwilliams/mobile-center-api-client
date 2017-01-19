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
    /// Summary single test run on Xamarin Test Cloud
    /// </summary>
    public partial class TestRun
    {
        /// <summary>
        /// Initializes a new instance of the TestRun class.
        /// </summary>
        public TestRun() { }

        /// <summary>
        /// Initializes a new instance of the TestRun class.
        /// </summary>
        public TestRun(Guid? id = default(Guid?), string date = default(string), string appVersion = default(string), string testSeries = default(string), string platform = default(string), string runStatus = default(string), string resultStatus = default(string), string state = default(string), string status = default(string), string description = default(string), TestRunStatistics stats = default(TestRunStatistics), string testType = default(string), string uploadedBy = default(string))
        {
            Id = id;
            Date = date;
            AppVersion = appVersion;
            TestSeries = testSeries;
            Platform = platform;
            RunStatus = runStatus;
            ResultStatus = resultStatus;
            State = state;
            Status = status;
            Description = description;
            Stats = stats;
            TestType = testType;
            UploadedBy = uploadedBy;
        }

        /// <summary>
        /// The unique id of the test upload
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// The date and time the test was uploaded
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        /// <summary>
        /// The compiled version of the app binary
        /// </summary>
        [JsonProperty(PropertyName = "appVersion")]
        public string AppVersion { get; set; }

        /// <summary>
        /// The name of the test series with which this test upload is
        /// associated
        /// </summary>
        [JsonProperty(PropertyName = "testSeries")]
        public string TestSeries { get; set; }

        /// <summary>
        /// The device platform targeted by the test. Possible values are
        /// 'ios' or 'android'
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// The current status of the test run, in relation to the various
        /// phases
        /// </summary>
        [JsonProperty(PropertyName = "runStatus")]
        public string RunStatus { get; set; }

        /// <summary>
        /// The passed/failed state
        /// </summary>
        [JsonProperty(PropertyName = "resultStatus")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// Deprecated. Use runStatus instead.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Deprecated. Use resultStatus instead.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Human readable explanation of the current test status
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public TestRunStatistics Stats { get; set; }

        /// <summary>
        /// The name of the test framework used to run this test
        /// </summary>
        [JsonProperty(PropertyName = "testType")]
        public string TestType { get; set; }

        /// <summary>
        /// The name of the user who uploaded the test
        /// </summary>
        [JsonProperty(PropertyName = "uploadedBy")]
        public string UploadedBy { get; set; }

    }
}
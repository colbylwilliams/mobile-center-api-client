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

    public partial class TestReportFeaturesItemTestsItem
    {
        /// <summary>
        /// Initializes a new instance of the TestReportFeaturesItemTestsItem
        /// class.
        /// </summary>
        public TestReportFeaturesItemTestsItem() { }

        /// <summary>
        /// Initializes a new instance of the TestReportFeaturesItemTestsItem
        /// class.
        /// </summary>
        public TestReportFeaturesItemTestsItem(string testName = default(string), IList<TestReportFeaturesItemTestsItemRunsItem> runs = default(IList<TestReportFeaturesItemTestsItemRunsItem>), double? peakMemory = default(double?), double? peakDuration = default(double?))
        {
            TestName = testName;
            Runs = runs;
            PeakMemory = peakMemory;
            PeakDuration = peakDuration;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testName")]
        public string TestName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runs")]
        public IList<TestReportFeaturesItemTestsItemRunsItem> Runs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "peakMemory")]
        public double? PeakMemory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "peakDuration")]
        public double? PeakDuration { get; set; }

    }
}

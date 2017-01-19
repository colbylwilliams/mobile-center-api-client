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

    public partial class TestReportFeaturesItem
    {
        /// <summary>
        /// Initializes a new instance of the TestReportFeaturesItem class.
        /// </summary>
        public TestReportFeaturesItem() { }

        /// <summary>
        /// Initializes a new instance of the TestReportFeaturesItem class.
        /// </summary>
        public TestReportFeaturesItem(string name = default(string), IList<TestReportFeaturesItemTestsItem> tests = default(IList<TestReportFeaturesItemTestsItem>), double? failed = default(double?), double? skipped = default(double?), double? peakMemory = default(double?), double? peakDuration = default(double?))
        {
            Name = name;
            Tests = tests;
            Failed = failed;
            Skipped = skipped;
            PeakMemory = peakMemory;
            PeakDuration = peakDuration;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tests")]
        public IList<TestReportFeaturesItemTestsItem> Tests { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipped")]
        public double? Skipped { get; set; }

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
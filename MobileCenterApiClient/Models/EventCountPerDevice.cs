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

    public partial class EventCountPerDevice
    {
        /// <summary>
        /// Initializes a new instance of the EventCountPerDevice class.
        /// </summary>
        public EventCountPerDevice() { }

        /// <summary>
        /// Initializes a new instance of the EventCountPerDevice class.
        /// </summary>
        public EventCountPerDevice(double? avgCountPerDevice = default(double?), double? previousAvgCountPerDevice = default(double?), IList<DateTimeDecimalCounts> countPerDevice = default(IList<DateTimeDecimalCounts>))
        {
            AvgCountPerDevice = avgCountPerDevice;
            PreviousAvgCountPerDevice = previousAvgCountPerDevice;
            CountPerDevice = countPerDevice;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "avg_count_per_device")]
        public double? AvgCountPerDevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previous_avg_count_per_device")]
        public double? PreviousAvgCountPerDevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count_per_device")]
        public IList<DateTimeDecimalCounts> CountPerDevice { get; set; }

    }
}

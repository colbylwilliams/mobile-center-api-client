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

    public partial class TestReport
    {
        /// <summary>
        /// Initializes a new instance of the TestReport class.
        /// </summary>
        public TestReport() { }

        /// <summary>
        /// Initializes a new instance of the TestReport class.
        /// </summary>
        public TestReport(string appUploadId, string date, string testType, string platform, TestReportStats stats, string id, double schemaVersion, double revision, IList<TestReportFeaturesItem> features, IList<string> finishedDeviceSnapshots, IList<TestReportDeviceLogsItem> deviceLogs, string dateFinished)
        {
            AppUploadId = appUploadId;
            Date = date;
            TestType = testType;
            Platform = platform;
            Stats = stats;
            Id = id;
            SchemaVersion = schemaVersion;
            Revision = revision;
            Features = features;
            FinishedDeviceSnapshots = finishedDeviceSnapshots;
            DeviceLogs = deviceLogs;
            DateFinished = dateFinished;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "app_upload_id")]
        public string AppUploadId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testType")]
        public string TestType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public TestReportStats Stats { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schema_version")]
        public double SchemaVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public double Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<TestReportFeaturesItem> Features { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "finished_device_snapshots")]
        public IList<string> FinishedDeviceSnapshots { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_logs")]
        public IList<TestReportDeviceLogsItem> DeviceLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date_finished")]
        public string DateFinished { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (AppUploadId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppUploadId");
            }
            if (Date == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Date");
            }
            if (TestType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TestType");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
            if (Stats == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Stats");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Features == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Features");
            }
            if (FinishedDeviceSnapshots == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FinishedDeviceSnapshots");
            }
            if (DeviceLogs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceLogs");
            }
            if (DateFinished == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DateFinished");
            }
        }
    }
}

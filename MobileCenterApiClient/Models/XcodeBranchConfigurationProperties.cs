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
    /// Build configuration when Xcode is part of the build steps
    /// </summary>
    public partial class XcodeBranchConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// XcodeBranchConfigurationProperties class.
        /// </summary>
        public XcodeBranchConfigurationProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// XcodeBranchConfigurationProperties class.
        /// </summary>
        public XcodeBranchConfigurationProperties(string projectOrWorkspacePath, string scheme, string xcodeVersion, string podfilePath = default(string), string provisioningProfileEncoded = default(string), string certificateEncoded = default(string), string certificatePassword = default(string), string provisioningProfileFilename = default(string), string certificateFilename = default(string), string teamId = default(string), bool? automaticSigning = default(bool?))
        {
            ProjectOrWorkspacePath = projectOrWorkspacePath;
            PodfilePath = podfilePath;
            ProvisioningProfileEncoded = provisioningProfileEncoded;
            CertificateEncoded = certificateEncoded;
            CertificatePassword = certificatePassword;
            Scheme = scheme;
            XcodeVersion = xcodeVersion;
            ProvisioningProfileFilename = provisioningProfileFilename;
            CertificateFilename = certificateFilename;
            TeamId = teamId;
            AutomaticSigning = automaticSigning;
        }

        /// <summary>
        /// Xcode project/workspace path
        /// </summary>
        [JsonProperty(PropertyName = "projectOrWorkspacePath")]
        public string ProjectOrWorkspacePath { get; set; }

        /// <summary>
        /// Path to CococaPods file, if present
        /// </summary>
        [JsonProperty(PropertyName = "podfilePath")]
        public string PodfilePath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provisioningProfileEncoded")]
        public string ProvisioningProfileEncoded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificateEncoded")]
        public string CertificateEncoded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificatePassword")]
        public string CertificatePassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xcodeVersion")]
        public string XcodeVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provisioningProfileFilename")]
        public string ProvisioningProfileFilename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificateFilename")]
        public string CertificateFilename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "automaticSigning")]
        public bool? AutomaticSigning { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ProjectOrWorkspacePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProjectOrWorkspacePath");
            }
            if (Scheme == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scheme");
            }
            if (XcodeVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "XcodeVersion");
            }
        }
    }
}

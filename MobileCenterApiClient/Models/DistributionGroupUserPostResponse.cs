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

    public partial class DistributionGroupUserPostResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupUserPostResponse class.
        /// </summary>
        public DistributionGroupUserPostResponse() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupUserPostResponse class.
        /// </summary>
        public DistributionGroupUserPostResponse(int status, string userId = default(string), string userEmail = default(string), string code = default(string), int? message = default(int?), bool? invitePending = default(bool?))
        {
            UserId = userId;
            UserEmail = userEmail;
            Status = status;
            Code = code;
            Message = message;
            InvitePending = invitePending;
        }

        /// <summary>
        /// The unique ID (UUID) of the user
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        [JsonProperty(PropertyName = "user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// The status code of the result
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }

        /// <summary>
        /// The code of the result
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The message of the result
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public int? Message { get; set; }

        /// <summary>
        /// Whether the has accepted the invite. Available when an invite is
        /// pending, and the value will be "true".
        /// </summary>
        [JsonProperty(PropertyName = "invite_pending")]
        public bool? InvitePending { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    public partial class GovernmentService : Service
    {
        public GovernmentService()
        {
            Type = "GovernmentService";
        }

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
        [JsonPropertyName("jurisdiction")]
        public virtual object? Jurisdiction { get; set; }

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
        [JsonPropertyName("serviceOperator")]
        public virtual Organization? ServiceOperator { get; set; }

    }
}

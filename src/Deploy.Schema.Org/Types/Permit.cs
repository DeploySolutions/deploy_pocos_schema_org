using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    public partial class Permit : Intangible
    {
        public Permit()
        {
            Type = "Permit";
        }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("issuedBy")]
        public virtual Organization? IssuedBy { get; set; }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("issuedThrough")]
        public virtual Service? IssuedThrough { get; set; }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("permitAudience")]
        public virtual Audience? PermitAudience { get; set; }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("validFor")]
        public virtual Duration? ValidFor { get; set; }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("validFrom")]
        public virtual object? ValidFrom { get; set; }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("validIn")]
        public virtual AdministrativeArea? ValidIn { get; set; }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
        [JsonPropertyName("validUntil")]
        public virtual DateTime? ValidUntil { get; set; }

    }
}

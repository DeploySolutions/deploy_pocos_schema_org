using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The mailing address.
    /// </summary>
    public partial class PostalAddress : ContactPoint
    {
        public PostalAddress()
        {
            Type = "PostalAddress";
        }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("addressCountry")]
        public virtual object? AddressCountry { get; set; }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("addressLocality")]
        public virtual string? AddressLocality { get; set; }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("addressRegion")]
        public virtual string? AddressRegion { get; set; }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("extendedAddress")]
        public virtual string? ExtendedAddress { get; set; }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("postalCode")]
        public virtual string? PostalCode { get; set; }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("postOfficeBoxNumber")]
        public virtual string? PostOfficeBoxNumber { get; set; }

    /// <summary>
    /// The mailing address.
    /// </summary>
        [JsonPropertyName("streetAddress")]
        public virtual string? StreetAddress { get; set; }

    }
}

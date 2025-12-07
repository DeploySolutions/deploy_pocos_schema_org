using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
    public partial class ContactPoint : StructuredValue
    {
        public ContactPoint()
        {
            Type = "ContactPoint";
        }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("areaServed")]
        public virtual object? AreaServed { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("availableLanguage")]
        public virtual object? AvailableLanguage { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("contactOption")]
        public virtual ContactPointOption? ContactOption { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("contactType")]
        public virtual string? ContactType { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("email")]
        public virtual string? Email { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("faxNumber")]
        public virtual string? FaxNumber { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("hoursAvailable")]
        public virtual OpeningHoursSpecification? HoursAvailable { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("productSupported")]
        public virtual object? ProductSupported { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("serviceArea")]
        public virtual object? ServiceArea { get; set; }

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// </summary>
        [JsonPropertyName("telephone")]
        public virtual string? Telephone { get; set; }

    }
}

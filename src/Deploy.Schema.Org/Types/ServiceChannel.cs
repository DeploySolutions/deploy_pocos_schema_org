using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
    public partial class ServiceChannel : Intangible
    {
        public ServiceChannel()
        {
            Type = "ServiceChannel";
        }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("availableLanguage")]
        public virtual object? AvailableLanguage { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("processingTime")]
        public virtual Duration? ProcessingTime { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("providesService")]
        public virtual Service? ProvidesService { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("serviceLocation")]
        public virtual Place? ServiceLocation { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("servicePhone")]
        public virtual ContactPoint? ServicePhone { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("servicePostalAddress")]
        public virtual PostalAddress? ServicePostalAddress { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("serviceSmsNumber")]
        public virtual ContactPoint? ServiceSmsNumber { get; set; }

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// </summary>
        [JsonPropertyName("serviceUrl")]
        public virtual string? ServiceUrl { get; set; }

    }
}

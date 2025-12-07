using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    public partial class ParcelDelivery : Intangible
    {
        public ParcelDelivery()
        {
            Type = "ParcelDelivery";
        }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("carrier")]
        public virtual Organization? Carrier { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("deliveryAddress")]
        public virtual PostalAddress? DeliveryAddress { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("deliveryStatus")]
        public virtual DeliveryEvent? DeliveryStatus { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("expectedArrivalFrom")]
        public virtual object? ExpectedArrivalFrom { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("expectedArrivalUntil")]
        public virtual object? ExpectedArrivalUntil { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("hasDeliveryMethod")]
        public virtual DeliveryMethod? HasDeliveryMethod { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("itemShipped")]
        public virtual Product? ItemShipped { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("originAddress")]
        public virtual PostalAddress? OriginAddress { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("partOfOrder")]
        public virtual Order? PartOfOrder { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("trackingNumber")]
        public virtual string? TrackingNumber { get; set; }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
        [JsonPropertyName("trackingUrl")]
        public virtual string? TrackingUrl { get; set; }

    }
}

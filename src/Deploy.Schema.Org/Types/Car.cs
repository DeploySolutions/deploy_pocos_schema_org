using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// </summary>
    public partial class Car : Vehicle
    {
        public Car()
        {
            Type = "Car";
        }

    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// </summary>
        [JsonPropertyName("acrissCode")]
        public virtual string? AcrissCode { get; set; }

    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// </summary>
        [JsonPropertyName("roofLoad")]
        public virtual QuantitativeValue? RoofLoad { get; set; }

    }
}

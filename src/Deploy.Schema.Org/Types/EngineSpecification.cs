using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    public partial class EngineSpecification : StructuredValue
    {
        public EngineSpecification()
        {
            Type = "EngineSpecification";
        }

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
        [JsonPropertyName("engineDisplacement")]
        public virtual QuantitativeValue? EngineDisplacement { get; set; }

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
        [JsonPropertyName("enginePower")]
        public virtual QuantitativeValue? EnginePower { get; set; }

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
        [JsonPropertyName("engineType")]
        public virtual object? EngineType { get; set; }

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
        [JsonPropertyName("fuelType")]
        public virtual object? FuelType { get; set; }

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
        [JsonPropertyName("torque")]
        public virtual QuantitativeValue? Torque { get; set; }

    }
}

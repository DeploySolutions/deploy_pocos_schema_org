using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    public partial class TypeAndQuantityNode : StructuredValue
    {
        public TypeAndQuantityNode()
        {
            Type = "TypeAndQuantityNode";
        }

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
        [JsonPropertyName("amountOfThisGood")]
        public virtual double? AmountOfThisGood { get; set; }

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
        [JsonPropertyName("businessFunction")]
        public virtual BusinessFunction? BusinessFunction { get; set; }

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
        [JsonPropertyName("typeOfGood")]
        public virtual object? TypeOfGood { get; set; }

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
        [JsonPropertyName("unitCode")]
        public virtual object? UnitCode { get; set; }

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
        [JsonPropertyName("unitText")]
        public virtual string? UnitText { get; set; }

    }
}

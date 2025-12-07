using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    public partial class WarrantyPromise : StructuredValue
    {
        public WarrantyPromise()
        {
            Type = "WarrantyPromise";
        }

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
        [JsonPropertyName("durationOfWarranty")]
        public virtual QuantitativeValue? DurationOfWarranty { get; set; }

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
        [JsonPropertyName("warrantyScope")]
        public virtual WarrantyScope? WarrantyScope { get; set; }

    }
}

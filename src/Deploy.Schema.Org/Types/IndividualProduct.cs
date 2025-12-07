using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    public partial class IndividualProduct : Product
    {
        public IndividualProduct()
        {
            Type = "IndividualProduct";
        }

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
        [JsonPropertyName("serialNumber")]
        public virtual string? SerialNumber { get; set; }

    }
}

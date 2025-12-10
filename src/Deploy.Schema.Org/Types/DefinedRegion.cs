using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    /// </summary>
    public partial class DefinedRegion : StructuredValue
    {
        public DefinedRegion()
        {
            Type = "DefinedRegion";
        }

    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    /// </summary>
        [JsonPropertyName("addressCountry")]
        public virtual object? AddressCountry { get; set; }

    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    /// </summary>
        [JsonPropertyName("addressRegion")]
        public virtual string? AddressRegion { get; set; }

    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    /// </summary>
        [JsonPropertyName("postalCode")]
        public virtual string? PostalCode { get; set; }

    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    /// </summary>
        [JsonPropertyName("postalCodePrefix")]
        public virtual string? PostalCodePrefix { get; set; }

    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    /// </summary>
        [JsonPropertyName("postalCodeRange")]
        public virtual PostalCodeRangeSpecification? PostalCodeRange { get; set; }

    }
}

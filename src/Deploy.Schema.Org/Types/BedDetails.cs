using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also [[BedType]] (under development).
    /// </summary>
    public partial class BedDetails : Intangible
    {
        public BedDetails()
        {
            Type = "BedDetails";
        }

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also [[BedType]] (under development).
    /// </summary>
        [JsonPropertyName("numberOfBeds")]
        public virtual double? NumberOfBeds { get; set; }

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also [[BedType]] (under development).
    /// </summary>
        [JsonPropertyName("typeOfBed")]
        public virtual object? TypeOfBed { get; set; }

    }
}

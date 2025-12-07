using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Indicates a range of postal codes, usually defined as the set of valid codes between [[postalCodeBegin]] and [[postalCodeEnd]], inclusively.
    /// </summary>
    public partial class PostalCodeRangeSpecification : StructuredValue
    {
        public PostalCodeRangeSpecification()
        {
            Type = "PostalCodeRangeSpecification";
        }

    /// <summary>
    /// Indicates a range of postal codes, usually defined as the set of valid codes between [[postalCodeBegin]] and [[postalCodeEnd]], inclusively.
    /// </summary>
        [JsonPropertyName("postalCodeBegin")]
        public virtual string? PostalCodeBegin { get; set; }

    /// <summary>
    /// Indicates a range of postal codes, usually defined as the set of valid codes between [[postalCodeBegin]] and [[postalCodeEnd]], inclusively.
    /// </summary>
        [JsonPropertyName("postalCodeEnd")]
        public virtual string? PostalCodeEnd { get; set; }

    }
}

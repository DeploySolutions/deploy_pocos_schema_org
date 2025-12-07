using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    public partial class BusinessAudience : Audience
    {
        public BusinessAudience()
        {
            Type = "BusinessAudience";
        }

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("numberOfEmployees")]
        public virtual QuantitativeValue? NumberOfEmployees { get; set; }

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("yearlyRevenue")]
        public virtual QuantitativeValue? YearlyRevenue { get; set; }

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("yearsInOperation")]
        public virtual QuantitativeValue? YearsInOperation { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Financial services business.
    /// </summary>
    public partial class FinancialService : LocalBusiness
    {
        public FinancialService()
        {
            Type = "FinancialService";
        }

    /// <summary>
    /// Financial services business.
    /// </summary>
        [JsonPropertyName("feesAndCommissionsSpecification")]
        public virtual object? FeesAndCommissionsSpecification { get; set; }

    }
}

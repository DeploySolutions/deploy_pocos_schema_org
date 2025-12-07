using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
    public partial class FinancialProduct : Service
    {
        public FinancialProduct()
        {
            Type = "FinancialProduct";
        }

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
        [JsonPropertyName("annualPercentageRate")]
        public virtual object? AnnualPercentageRate { get; set; }

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
        [JsonPropertyName("feesAndCommissionsSpecification")]
        public virtual object? FeesAndCommissionsSpecification { get; set; }

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
        [JsonPropertyName("interestRate")]
        public virtual object? InterestRate { get; set; }

    }
}

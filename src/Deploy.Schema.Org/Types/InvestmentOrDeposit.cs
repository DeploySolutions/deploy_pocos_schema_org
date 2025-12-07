using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    public partial class InvestmentOrDeposit : FinancialProduct
    {
        public InvestmentOrDeposit()
        {
            Type = "InvestmentOrDeposit";
        }

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
        [JsonPropertyName("amount")]
        public virtual object? Amount { get; set; }

    }
}

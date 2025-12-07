using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
    public partial class LoanOrCredit : FinancialProduct
    {
        public LoanOrCredit()
        {
            Type = "LoanOrCredit";
        }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("amount")]
        public virtual object? Amount { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("currency")]
        public virtual string? Currency { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("gracePeriod")]
        public virtual Duration? GracePeriod { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("loanRepaymentForm")]
        public virtual RepaymentSpecification? LoanRepaymentForm { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("loanTerm")]
        public virtual QuantitativeValue? LoanTerm { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("loanType")]
        public virtual object? LoanType { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("recourseLoan")]
        public virtual bool? RecourseLoan { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("renegotiableLoan")]
        public virtual bool? RenegotiableLoan { get; set; }

    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// </summary>
        [JsonPropertyName("requiredCollateral")]
        public virtual object? RequiredCollateral { get; set; }

    }
}

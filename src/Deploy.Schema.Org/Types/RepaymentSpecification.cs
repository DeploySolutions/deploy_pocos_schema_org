using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value representing repayment.
    /// </summary>
    public partial class RepaymentSpecification : StructuredValue
    {
        public RepaymentSpecification()
        {
            Type = "RepaymentSpecification";
        }

    /// <summary>
    /// A structured value representing repayment.
    /// </summary>
        [JsonPropertyName("downPayment")]
        public virtual object? DownPayment { get; set; }

    /// <summary>
    /// A structured value representing repayment.
    /// </summary>
        [JsonPropertyName("earlyPrepaymentPenalty")]
        public virtual MonetaryAmount? EarlyPrepaymentPenalty { get; set; }

    /// <summary>
    /// A structured value representing repayment.
    /// </summary>
        [JsonPropertyName("loanPaymentAmount")]
        public virtual MonetaryAmount? LoanPaymentAmount { get; set; }

    /// <summary>
    /// A structured value representing repayment.
    /// </summary>
        [JsonPropertyName("loanPaymentFrequency")]
        public virtual double? LoanPaymentFrequency { get; set; }

    /// <summary>
    /// A structured value representing repayment.
    /// </summary>
        [JsonPropertyName("numberOfLoanPayments")]
        public virtual double? NumberOfLoanPayments { get; set; }

    }
}

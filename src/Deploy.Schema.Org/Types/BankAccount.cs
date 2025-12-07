using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
    public partial class BankAccount : FinancialProduct
    {
        public BankAccount()
        {
            Type = "BankAccount";
        }

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
        [JsonPropertyName("accountMinimumInflow")]
        public virtual MonetaryAmount? AccountMinimumInflow { get; set; }

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
        [JsonPropertyName("accountOverdraftLimit")]
        public virtual MonetaryAmount? AccountOverdraftLimit { get; set; }

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
        [JsonPropertyName("bankAccountType")]
        public virtual object? BankAccountType { get; set; }

    }
}

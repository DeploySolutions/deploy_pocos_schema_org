using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
    public partial class PaymentCard : FinancialProduct
    {
        public PaymentCard()
        {
            Type = "PaymentCard";
        }

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
        [JsonPropertyName("cashBack")]
        public virtual object? CashBack { get; set; }

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
        [JsonPropertyName("contactlessPayment")]
        public virtual bool? ContactlessPayment { get; set; }

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
        [JsonPropertyName("floorLimit")]
        public virtual MonetaryAmount? FloorLimit { get; set; }

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
        [JsonPropertyName("monthlyMinimumRepaymentAmount")]
        public virtual object? MonthlyMinimumRepaymentAmount { get; set; }

    }
}

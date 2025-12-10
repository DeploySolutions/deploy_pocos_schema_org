using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
    public partial class FinancialIncentive : Intangible
    {
        public FinancialIncentive()
        {
            Type = "FinancialIncentive";
        }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("areaServed")]
        public virtual object? AreaServed { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("eligibleWithSupplier")]
        public virtual Organization? EligibleWithSupplier { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("incentiveAmount")]
        public virtual object? IncentiveAmount { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("incentiveStatus")]
        public virtual IncentiveStatus? IncentiveStatus { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("incentiveType")]
        public virtual IncentiveType? IncentiveType { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("incentivizedItem")]
        public virtual object? IncentivizedItem { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("incomeLimit")]
        public virtual object? IncomeLimit { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("publisher")]
        public virtual object? Publisher { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("purchasePriceLimit")]
        public virtual MonetaryAmount? PurchasePriceLimit { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("purchaseType")]
        public virtual PurchaseType? PurchaseType { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("qualifiedExpense")]
        public virtual IncentiveQualifiedExpenseType? QualifiedExpense { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("validFrom")]
        public virtual object? ValidFrom { get; set; }

    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    /// </summary>
        [JsonPropertyName("validThrough")]
        public virtual object? ValidThrough { get; set; }

    }
}

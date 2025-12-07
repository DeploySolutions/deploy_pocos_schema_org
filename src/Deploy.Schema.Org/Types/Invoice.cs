using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    public partial class Invoice : Intangible
    {
        public Invoice()
        {
            Type = "Invoice";
        }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("accountId")]
        public virtual string? AccountId { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("billingPeriod")]
        public virtual Duration? BillingPeriod { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("broker")]
        public virtual object? Broker { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("category")]
        public virtual object? Category { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("confirmationNumber")]
        public virtual string? ConfirmationNumber { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("customer")]
        public virtual object? Customer { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("minimumPaymentDue")]
        public virtual object? MinimumPaymentDue { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("paymentDue")]
        public virtual DateTime? PaymentDue { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("paymentDueDate")]
        public virtual object? PaymentDueDate { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("paymentMethod")]
        public virtual object? PaymentMethod { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("paymentMethodId")]
        public virtual string? PaymentMethodId { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("paymentStatus")]
        public virtual object? PaymentStatus { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("referencesOrder")]
        public virtual Order? ReferencesOrder { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("scheduledPaymentDate")]
        public virtual DateTime? ScheduledPaymentDate { get; set; }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
        [JsonPropertyName("totalPaymentDue")]
        public virtual object? TotalPaymentDue { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
    public partial class Order : Intangible
    {
        public Order()
        {
            Type = "Order";
        }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("acceptedOffer")]
        public virtual Offer? AcceptedOffer { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("billingAddress")]
        public virtual PostalAddress? BillingAddress { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("broker")]
        public virtual object? Broker { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("confirmationNumber")]
        public virtual string? ConfirmationNumber { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("customer")]
        public virtual object? Customer { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("discount")]
        public virtual object? Discount { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("discountCode")]
        public virtual string? DiscountCode { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("discountCurrency")]
        public virtual string? DiscountCurrency { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("isGift")]
        public virtual bool? IsGift { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("merchant")]
        public virtual object? Merchant { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("orderDate")]
        public virtual object? OrderDate { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("orderDelivery")]
        public virtual ParcelDelivery? OrderDelivery { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("orderedItem")]
        public virtual object? OrderedItem { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("orderNumber")]
        public virtual string? OrderNumber { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("orderStatus")]
        public virtual OrderStatus? OrderStatus { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("partOfInvoice")]
        public virtual Invoice? PartOfInvoice { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("paymentDue")]
        public virtual DateTime? PaymentDue { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("paymentDueDate")]
        public virtual object? PaymentDueDate { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("paymentMethod")]
        public virtual object? PaymentMethod { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("paymentMethodId")]
        public virtual string? PaymentMethodId { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("paymentUrl")]
        public virtual string? PaymentUrl { get; set; }

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// </summary>
        [JsonPropertyName("seller")]
        public virtual object? Seller { get; set; }

    }
}

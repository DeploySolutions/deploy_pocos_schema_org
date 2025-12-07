using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The type of payment method, only for generic payment types, specific forms of payments, like card payment should be expressed using subclasses of PaymentMethod.
    /// </summary>
    public partial class PaymentMethodType : Enumeration
    {
        public PaymentMethodType()
        {
            Type = "PaymentMethodType";
        }

    }
}

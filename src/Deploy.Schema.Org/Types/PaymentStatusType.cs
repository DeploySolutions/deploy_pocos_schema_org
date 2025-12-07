using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// </summary>
    public partial class PaymentStatusType : StatusEnumeration
    {
        public PaymentStatusType()
        {
            Type = "PaymentStatusType";
        }

    }
}

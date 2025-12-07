using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    public partial class PaymentService : FinancialProduct
    {
        public PaymentService()
        {
            Type = "PaymentService";
        }

    }
}

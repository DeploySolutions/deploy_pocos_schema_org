using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Bank or credit union.
    /// </summary>
    public partial class BankOrCreditUnion : FinancialService
    {
        public BankOrCreditUnion()
        {
            Type = "BankOrCreditUnion";
        }

    }
}

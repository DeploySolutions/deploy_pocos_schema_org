using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An account that allows an investor to deposit funds and place investment orders with a licensed broker or brokerage firm.
    /// </summary>
    public partial class BrokerageAccount : InvestmentOrDeposit
    {
        public BrokerageAccount()
        {
            Type = "BrokerageAccount";
        }

    }
}

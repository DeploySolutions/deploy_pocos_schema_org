using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A company or fund that gathers capital from a number of investors to create a pool of money that is then re-invested into stocks, bonds and other assets.
    /// </summary>
    public partial class InvestmentFund : InvestmentOrDeposit
    {
        public InvestmentFund()
        {
            Type = "InvestmentFund";
        }

    }
}

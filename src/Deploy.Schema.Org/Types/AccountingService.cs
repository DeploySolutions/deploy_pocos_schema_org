using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Accountancy business.\n\nAs a [[LocalBusiness]] it can be described as a [[provider]] of one or more [[Service]]\(s).
    /// </summary>
    public partial class AccountingService : FinancialService
    {
        public AccountingService()
        {
            Type = "AccountingService";
        }

    }
}

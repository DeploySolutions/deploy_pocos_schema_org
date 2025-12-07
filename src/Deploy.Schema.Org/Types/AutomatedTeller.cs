using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// ATM/cash machine.
    /// </summary>
    public partial class AutomatedTeller : FinancialService
    {
        public AutomatedTeller()
        {
            Type = "AutomatedTeller";
        }

    }
}

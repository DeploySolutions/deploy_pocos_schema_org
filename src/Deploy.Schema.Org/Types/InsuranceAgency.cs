using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An Insurance agency.
    /// </summary>
    public partial class InsuranceAgency : FinancialService
    {
        public InsuranceAgency()
        {
            Type = "InsuranceAgency";
        }

    }
}

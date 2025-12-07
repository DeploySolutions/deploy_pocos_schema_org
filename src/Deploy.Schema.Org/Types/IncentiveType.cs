using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates common financial incentives for products, including tax credits, tax deductions, rebates and subsidies, etc.
    /// </summary>
    public partial class IncentiveType : Enumeration
    {
        public IncentiveType()
        {
            Type = "IncentiveType";
        }

    }
}

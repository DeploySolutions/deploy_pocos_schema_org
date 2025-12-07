using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The types of expenses that are covered by the incentive. For example some incentives are only for the goods (tangible items) but the services (labor) are excluded.
    /// </summary>
    public partial class IncentiveQualifiedExpenseType : Enumeration
    {
        public IncentiveQualifiedExpenseType()
        {
            Type = "IncentiveQualifiedExpenseType";
        }

    }
}

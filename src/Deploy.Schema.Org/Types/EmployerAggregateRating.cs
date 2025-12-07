using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    public partial class EmployerAggregateRating : AggregateRating
    {
        public EmployerAggregateRating()
        {
            Type = "EmployerAggregateRating";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Childcare center.
    /// </summary>
    public partial class ChildCare : LocalBusiness
    {
        public ChildCare()
        {
            Type = "ChildCare";
        }

    }
}

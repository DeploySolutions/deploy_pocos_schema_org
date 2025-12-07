using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A recycling center.
    /// </summary>
    public partial class RecyclingCenter : LocalBusiness
    {
        public RecyclingCenter()
        {
            Type = "RecyclingCenter";
        }

    }
}

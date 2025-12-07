using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An eCommerce site.
    /// </summary>
    public partial class OnlineStore : OnlineBusiness
    {
        public OnlineStore()
        {
            Type = "OnlineStore";
        }

    }
}

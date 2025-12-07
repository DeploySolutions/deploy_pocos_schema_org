using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An internet cafe.
    /// </summary>
    public partial class InternetCafe : LocalBusiness
    {
        public InternetCafe()
        {
            Type = "InternetCafe";
        }

    }
}

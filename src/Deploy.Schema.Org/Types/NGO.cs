using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    public partial class NGO : Organization
    {
        public NGO()
        {
            Type = "NGO";
        }

    }
}

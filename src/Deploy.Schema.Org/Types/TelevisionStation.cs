using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A television station.
    /// </summary>
    public partial class TelevisionStation : LocalBusiness
    {
        public TelevisionStation()
        {
            Type = "TelevisionStation";
        }

    }
}

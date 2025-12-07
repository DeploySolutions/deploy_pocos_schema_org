using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A self-storage facility.
    /// </summary>
    public partial class SelfStorage : LocalBusiness
    {
        public SelfStorage()
        {
            Type = "SelfStorage";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A taxi.
    /// </summary>
    public partial class Taxi : Service
    {
        public Taxi()
        {
            Type = "Taxi";
        }

    }
}

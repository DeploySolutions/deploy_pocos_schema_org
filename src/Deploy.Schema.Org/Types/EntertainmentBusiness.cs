using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    public partial class EntertainmentBusiness : LocalBusiness
    {
        public EntertainmentBusiness()
        {
            Type = "EntertainmentBusiness";
        }

    }
}

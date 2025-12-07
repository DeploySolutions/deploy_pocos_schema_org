using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    public partial class PerformAction : PlayAction
    {
        public PerformAction()
        {
            Type = "PerformAction";
        }

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
        [JsonPropertyName("entertainmentBusiness")]
        public virtual EntertainmentBusiness? EntertainmentBusiness { get; set; }

    }
}

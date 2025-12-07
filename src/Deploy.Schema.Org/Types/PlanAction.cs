using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    public partial class PlanAction : OrganizeAction
    {
        public PlanAction()
        {
            Type = "PlanAction";
        }

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
        [JsonPropertyName("scheduledTime")]
        public virtual object? ScheduledTime { get; set; }

    }
}

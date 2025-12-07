using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Scheduling future actions, events, or tasks.\n\nRelated actions:\n\n* [[ReserveAction]]: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation.
    /// </summary>
    public partial class ScheduleAction : PlanAction
    {
        public ScheduleAction()
        {
            Type = "ScheduleAction";
        }

    }
}

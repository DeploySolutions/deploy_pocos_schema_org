using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Reserving a concrete object.\n\nRelated actions:\n\n* [[ScheduleAction]]: Unlike ScheduleAction, ReserveAction reserves concrete objects (e.g. a table, a hotel) towards a time slot / spatial allocation.
    /// </summary>
    public partial class ReserveAction : PlanAction
    {
        public ReserveAction()
        {
            Type = "ReserveAction";
        }

    }
}

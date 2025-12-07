using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.\n\nRelated actions:\n\n* [[ConfirmAction]]: The antonym of CancelAction.
    /// </summary>
    public partial class CancelAction : PlanAction
    {
        public CancelAction()
        {
            Type = "CancelAction";
        }

    }
}

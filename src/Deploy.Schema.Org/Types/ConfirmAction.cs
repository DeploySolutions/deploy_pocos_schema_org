using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.\n\nRelated actions:\n\n* [[CancelAction]]: The antonym of ConfirmAction.
    /// </summary>
    public partial class ConfirmAction : InformAction
    {
        public ConfirmAction()
        {
            Type = "ConfirmAction";
        }

    }
}

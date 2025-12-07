using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of committing to/adopting an object.\n\nRelated actions:\n\n* [[RejectAction]]: The antonym of AcceptAction.
    /// </summary>
    public partial class AcceptAction : AllocateAction
    {
        public AcceptAction()
        {
            Type = "AcceptAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of rejecting to/adopting an object.\n\nRelated actions:\n\n* [[AcceptAction]]: The antonym of RejectAction.
    /// </summary>
    public partial class RejectAction : AllocateAction
    {
        public RejectAction()
        {
            Type = "RejectAction";
        }

    }
}

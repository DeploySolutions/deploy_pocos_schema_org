using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.\n\nRelated actions:\n\n* [[RegisterAction]]: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.
    /// </summary>
    public partial class ApplyAction : OrganizeAction
    {
        public ApplyAction()
        {
            Type = "ApplyAction";
        }

    }
}

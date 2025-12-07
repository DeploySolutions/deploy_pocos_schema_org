using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public partial class AllocateAction : OrganizeAction
    {
        public AllocateAction()
        {
            Type = "AllocateAction";
        }

    }
}

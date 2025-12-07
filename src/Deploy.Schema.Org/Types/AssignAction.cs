using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    public partial class AssignAction : AllocateAction
    {
        public AssignAction()
        {
            Type = "AssignAction";
        }

    }
}

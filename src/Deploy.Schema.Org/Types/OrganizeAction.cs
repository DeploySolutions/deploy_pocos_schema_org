using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// </summary>
    public partial class OrganizeAction : Action
    {
        public OrganizeAction()
        {
            Type = "OrganizeAction";
        }

    }
}

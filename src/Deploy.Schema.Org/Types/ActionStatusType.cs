using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The status of an Action.
    /// </summary>
    public partial class ActionStatusType : StatusEnumeration
    {
        public ActionStatusType()
        {
            Type = "ActionStatusType";
        }

    }
}

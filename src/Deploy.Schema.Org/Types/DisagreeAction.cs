using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial class DisagreeAction : ReactAction
    {
        public DisagreeAction()
        {
            Type = "DisagreeAction";
        }

    }
}

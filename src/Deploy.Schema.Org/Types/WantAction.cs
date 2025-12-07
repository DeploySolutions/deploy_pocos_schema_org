using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    public partial class WantAction : ReactAction
    {
        public WantAction()
        {
            Type = "WantAction";
        }

    }
}

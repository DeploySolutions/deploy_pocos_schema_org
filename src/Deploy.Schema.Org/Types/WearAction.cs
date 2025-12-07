using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    public partial class WearAction : UseAction
    {
        public WearAction()
        {
            Type = "WearAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of discovering/finding an object.
    /// </summary>
    public partial class DiscoverAction : FindAction
    {
        public DiscoverAction()
        {
            Type = "DiscoverAction";
        }

    }
}

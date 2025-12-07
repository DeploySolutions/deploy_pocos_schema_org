using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of finding an object.\n\nRelated actions:\n\n* [[SearchAction]]: FindAction is generally lead by a SearchAction, but not necessarily.
    /// </summary>
    public partial class FindAction : Action
    {
        public FindAction()
        {
            Type = "FindAction";
        }

    }
}

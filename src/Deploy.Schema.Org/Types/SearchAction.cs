using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of searching for an object.\n\nRelated actions:\n\n* [[FindAction]]: SearchAction generally leads to a FindAction, but not necessarily.
    /// </summary>
    public partial class SearchAction : Action
    {
        public SearchAction()
        {
            Type = "SearchAction";
        }

    /// <summary>
    /// The act of searching for an object.\n\nRelated actions:\n\n* [[FindAction]]: SearchAction generally leads to a FindAction, but not necessarily.
    /// </summary>
        [JsonPropertyName("query")]
        public virtual string? Query { get; set; }

    }
}

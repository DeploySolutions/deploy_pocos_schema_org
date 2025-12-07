using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    public partial class ListenAction : ConsumeAction
    {
        public ListenAction()
        {
            Type = "ListenAction";
        }

    }
}

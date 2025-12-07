using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    public partial class ReadAction : ConsumeAction
    {
        public ReadAction()
        {
            Type = "ReadAction";
        }

    }
}

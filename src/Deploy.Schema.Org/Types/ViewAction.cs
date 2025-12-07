using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of consuming static visual content.
    /// </summary>
    public partial class ViewAction : ConsumeAction
    {
        public ViewAction()
        {
            Type = "ViewAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial class DislikeAction : ReactAction
    {
        public DislikeAction()
        {
            Type = "DislikeAction";
        }

    }
}

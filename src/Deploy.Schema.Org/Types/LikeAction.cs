using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial class LikeAction : ReactAction
    {
        public LikeAction()
        {
            Type = "LikeAction";
        }

    }
}

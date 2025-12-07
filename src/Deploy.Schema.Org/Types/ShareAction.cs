using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    public partial class ShareAction : CommunicateAction
    {
        public ShareAction()
        {
            Type = "ShareAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of installing an application.
    /// </summary>
    public partial class InstallAction : ConsumeAction
    {
        public InstallAction()
        {
            Type = "InstallAction";
        }

    }
}

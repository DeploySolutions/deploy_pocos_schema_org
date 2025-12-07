using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    public partial class InteractAction : Action
    {
        public InteractAction()
        {
            Type = "InteractAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    public partial class CreateAction : Action
    {
        public CreateAction()
        {
            Type = "CreateAction";
        }

    }
}

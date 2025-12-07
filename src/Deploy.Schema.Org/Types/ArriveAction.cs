using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// </summary>
    public partial class ArriveAction : MoveAction
    {
        public ArriveAction()
        {
            Type = "ArriveAction";
        }

    }
}

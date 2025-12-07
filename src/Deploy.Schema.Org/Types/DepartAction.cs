using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of  departing from a place. An agent departs from a fromLocation for a destination, optionally with participants.
    /// </summary>
    public partial class DepartAction : MoveAction
    {
        public DepartAction()
        {
            Type = "DepartAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of marrying a person.
    /// </summary>
    public partial class MarryAction : InteractAction
    {
        public MarryAction()
        {
            Type = "MarryAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    public partial class DrinkAction : ConsumeAction
    {
        public DrinkAction()
        {
            Type = "DrinkAction";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// </summary>
    public partial class TieAction : AchieveAction
    {
        public TieAction()
        {
            Type = "TieAction";
        }

    }
}

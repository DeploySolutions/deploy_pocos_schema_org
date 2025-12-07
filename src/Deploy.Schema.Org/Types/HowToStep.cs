using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// </summary>
    public partial class HowToStep : ItemList
    {
        public HowToStep()
        {
            Type = "HowToStep";
        }

    }
}

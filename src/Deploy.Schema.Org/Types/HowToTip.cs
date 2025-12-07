using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    /// </summary>
    public partial class HowToTip : CreativeWork
    {
        public HowToTip()
        {
            Type = "HowToTip";
        }

    }
}

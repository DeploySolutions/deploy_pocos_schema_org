using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// </summary>
    public partial class HowToTool : HowToItem
    {
        public HowToTool()
        {
            Type = "HowToTool";
        }

    }
}

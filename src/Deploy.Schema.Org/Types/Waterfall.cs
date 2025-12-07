using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A waterfall, like Niagara.
    /// </summary>
    public partial class Waterfall : BodyOfWater
    {
        public Waterfall()
        {
            Type = "Waterfall";
        }

    }
}

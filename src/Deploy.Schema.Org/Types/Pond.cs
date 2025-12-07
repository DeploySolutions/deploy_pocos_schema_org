using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A pond.
    /// </summary>
    public partial class Pond : BodyOfWater
    {
        public Pond()
        {
            Type = "Pond";
        }

    }
}

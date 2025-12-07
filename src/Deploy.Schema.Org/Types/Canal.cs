using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    public partial class Canal : BodyOfWater
    {
        public Canal()
        {
            Type = "Canal";
        }

    }
}

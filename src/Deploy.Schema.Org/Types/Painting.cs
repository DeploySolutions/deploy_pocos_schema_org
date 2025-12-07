using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A painting.
    /// </summary>
    public partial class Painting : CreativeWork
    {
        public Painting()
        {
            Type = "Painting";
        }

    }
}

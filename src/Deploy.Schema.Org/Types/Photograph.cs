using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A photograph.
    /// </summary>
    public partial class Photograph : CreativeWork
    {
        public Photograph()
        {
            Type = "Photograph";
        }

    }
}

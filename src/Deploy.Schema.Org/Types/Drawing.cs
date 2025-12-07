using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A picture or diagram made with a pencil, pen, or crayon rather than paint.
    /// </summary>
    public partial class Drawing : CreativeWork
    {
        public Drawing()
        {
            Type = "Drawing";
        }

    }
}

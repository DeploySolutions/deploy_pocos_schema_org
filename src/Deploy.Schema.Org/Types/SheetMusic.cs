using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Printed music, as opposed to performed or recorded music.
    /// </summary>
    public partial class SheetMusic : CreativeWork
    {
        public SheetMusic()
        {
            Type = "SheetMusic";
        }

    }
}

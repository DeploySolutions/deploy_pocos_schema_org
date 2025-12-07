using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A book, document, or piece of music written by hand rather than typed or printed.
    /// </summary>
    public partial class Manuscript : CreativeWork
    {
        public Manuscript()
        {
            Type = "Manuscript";
        }

    }
}

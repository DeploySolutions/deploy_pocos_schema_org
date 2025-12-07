using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    public partial class NoteDigitalDocument : DigitalDocument
    {
        public NoteDigitalDocument()
        {
            Type = "NoteDigitalDocument";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A file containing slides or used for a presentation.
    /// </summary>
    public partial class PresentationDigitalDocument : DigitalDocument
    {
        public PresentationDigitalDocument()
        {
            Type = "PresentationDigitalDocument";
        }

    }
}

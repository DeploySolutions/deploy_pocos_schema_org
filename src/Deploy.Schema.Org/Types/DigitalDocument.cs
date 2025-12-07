using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An electronic file or document.
    /// </summary>
    public partial class DigitalDocument : CreativeWork
    {
        public DigitalDocument()
        {
            Type = "DigitalDocument";
        }

    /// <summary>
    /// An electronic file or document.
    /// </summary>
        [JsonPropertyName("hasDigitalDocumentPermission")]
        public virtual DigitalDocumentPermission? HasDigitalDocumentPermission { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    public partial class ArchiveComponent : CreativeWork
    {
        public ArchiveComponent()
        {
            Type = "ArchiveComponent";
        }

        [JsonPropertyName("holdingArchive")]
        public virtual ArchiveOrganization? HoldingArchive { get; set; }

        [JsonPropertyName("itemLocation")]
        public virtual object? ItemLocation { get; set; }

    }
}

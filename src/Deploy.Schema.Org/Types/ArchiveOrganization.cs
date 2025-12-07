using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    public partial class ArchiveOrganization : LocalBusiness
    {
        public ArchiveOrganization()
        {
            Type = "ArchiveOrganization";
        }

        [JsonPropertyName("archiveHeld")]
        public virtual ArchiveComponent? ArchiveHeld { get; set; }

    }
}

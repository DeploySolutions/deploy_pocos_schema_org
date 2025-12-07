using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    public partial class GatedResidenceCommunity : Residence
    {
        public GatedResidenceCommunity()
        {
            Type = "GatedResidenceCommunity";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// </summary>
    public partial class MobileApplication : SoftwareApplication
    {
        public MobileApplication()
        {
            Type = "MobileApplication";
        }

    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// </summary>
        [JsonPropertyName("carrierRequirements")]
        public virtual string? CarrierRequirements { get; set; }

    }
}

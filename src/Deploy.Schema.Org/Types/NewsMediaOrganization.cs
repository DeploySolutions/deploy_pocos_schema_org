using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
    public partial class NewsMediaOrganization : Organization
    {
        public NewsMediaOrganization()
        {
            Type = "NewsMediaOrganization";
        }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("actionableFeedbackPolicy")]
        public virtual object? ActionableFeedbackPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("correctionsPolicy")]
        public virtual object? CorrectionsPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("diversityPolicy")]
        public virtual object? DiversityPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("diversityStaffingReport")]
        public virtual object? DiversityStaffingReport { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("ethicsPolicy")]
        public virtual object? EthicsPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("masthead")]
        public virtual object? Masthead { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("missionCoveragePrioritiesPolicy")]
        public virtual object? MissionCoveragePrioritiesPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("noBylinesPolicy")]
        public virtual object? NoBylinesPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("ownershipFundingInfo")]
        public virtual object? OwnershipFundingInfo { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("unnamedSourcesPolicy")]
        public virtual object? UnnamedSourcesPolicy { get; set; }

    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// </summary>
        [JsonPropertyName("verificationFactCheckingPolicy")]
        public virtual object? VerificationFactCheckingPolicy { get; set; }

    }
}

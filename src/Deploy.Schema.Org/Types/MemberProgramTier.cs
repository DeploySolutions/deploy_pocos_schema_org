using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A MemberProgramTier specifies a tier under a loyalty (member) program, for example "gold".
    /// </summary>
    public partial class MemberProgramTier : Intangible
    {
        public MemberProgramTier()
        {
            Type = "MemberProgramTier";
        }

    /// <summary>
    /// A MemberProgramTier specifies a tier under a loyalty (member) program, for example "gold".
    /// </summary>
        [JsonPropertyName("hasTierBenefit")]
        public virtual TierBenefitEnumeration? HasTierBenefit { get; set; }

    /// <summary>
    /// A MemberProgramTier specifies a tier under a loyalty (member) program, for example "gold".
    /// </summary>
        [JsonPropertyName("hasTierRequirement")]
        public virtual object? HasTierRequirement { get; set; }

    /// <summary>
    /// A MemberProgramTier specifies a tier under a loyalty (member) program, for example "gold".
    /// </summary>
        [JsonPropertyName("isTierOf")]
        public virtual MemberProgram? IsTierOf { get; set; }

    /// <summary>
    /// A MemberProgramTier specifies a tier under a loyalty (member) program, for example "gold".
    /// </summary>
        [JsonPropertyName("membershipPointsEarned")]
        public virtual object? MembershipPointsEarned { get; set; }

    }
}

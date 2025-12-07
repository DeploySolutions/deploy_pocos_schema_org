using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A MemberProgram defines a loyalty (or membership) program that provides its members with certain benefits, for example better pricing, free shipping or returns, or the ability to earn loyalty points. Member programs may have multiple tiers, for example silver and gold members, each with different benefits.
    /// </summary>
    public partial class MemberProgram : Intangible
    {
        public MemberProgram()
        {
            Type = "MemberProgram";
        }

    /// <summary>
    /// A MemberProgram defines a loyalty (or membership) program that provides its members with certain benefits, for example better pricing, free shipping or returns, or the ability to earn loyalty points. Member programs may have multiple tiers, for example silver and gold members, each with different benefits.
    /// </summary>
        [JsonPropertyName("hasTiers")]
        public virtual MemberProgramTier? HasTiers { get; set; }

    /// <summary>
    /// A MemberProgram defines a loyalty (or membership) program that provides its members with certain benefits, for example better pricing, free shipping or returns, or the ability to earn loyalty points. Member programs may have multiple tiers, for example silver and gold members, each with different benefits.
    /// </summary>
        [JsonPropertyName("hostingOrganization")]
        public virtual Organization? HostingOrganization { get; set; }

    }
}

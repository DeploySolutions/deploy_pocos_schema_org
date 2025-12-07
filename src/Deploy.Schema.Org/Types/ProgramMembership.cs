using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    public partial class ProgramMembership : Intangible
    {
        public ProgramMembership()
        {
            Type = "ProgramMembership";
        }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("hostingOrganization")]
        public virtual Organization? HostingOrganization { get; set; }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("member")]
        public virtual object? Member { get; set; }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("members")]
        public virtual object? Members { get; set; }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("membershipNumber")]
        public virtual string? MembershipNumber { get; set; }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("membershipPointsEarned")]
        public virtual object? MembershipPointsEarned { get; set; }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("program")]
        public virtual MemberProgram? Program { get; set; }

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
        [JsonPropertyName("programName")]
        public virtual string? ProgramName { get; set; }

    }
}

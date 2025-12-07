using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
    public partial class Legislation : CreativeWork
    {
        public Legislation()
        {
            Type = "Legislation";
        }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("jurisdiction")]
        public virtual object? Jurisdiction { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationAmends")]
        public virtual Legislation? LegislationAmends { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationApplies")]
        public virtual Legislation? LegislationApplies { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationChanges")]
        public virtual Legislation? LegislationChanges { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationCommences")]
        public virtual Legislation? LegislationCommences { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationConsolidates")]
        public virtual Legislation? LegislationConsolidates { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationCorrects")]
        public virtual Legislation? LegislationCorrects { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationCountersignedBy")]
        public virtual object? LegislationCountersignedBy { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationDate")]
        public virtual DateTime? LegislationDate { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationDateOfApplicability")]
        public virtual DateTime? LegislationDateOfApplicability { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationDateVersion")]
        public virtual DateTime? LegislationDateVersion { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationEnsuresImplementationOf")]
        public virtual Legislation? LegislationEnsuresImplementationOf { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationIdentifier")]
        public virtual object? LegislationIdentifier { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationJurisdiction")]
        public virtual object? LegislationJurisdiction { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationLegalForce")]
        public virtual LegalForceStatus? LegislationLegalForce { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationPassedBy")]
        public virtual object? LegislationPassedBy { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationRepeals")]
        public virtual Legislation? LegislationRepeals { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationResponsible")]
        public virtual object? LegislationResponsible { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationTransposes")]
        public virtual Legislation? LegislationTransposes { get; set; }

    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// </summary>
        [JsonPropertyName("legislationType")]
        public virtual object? LegislationType { get; set; }

    }
}

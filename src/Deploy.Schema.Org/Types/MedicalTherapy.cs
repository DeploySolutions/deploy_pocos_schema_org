using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
    public partial class MedicalTherapy : TherapeuticProcedure
    {
        public MedicalTherapy()
        {
            Type = "MedicalTherapy";
        }

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
        [JsonPropertyName("contraindication")]
        public virtual object? Contraindication { get; set; }

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
        [JsonPropertyName("duplicateTherapy")]
        public virtual MedicalTherapy? DuplicateTherapy { get; set; }

    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// </summary>
        [JsonPropertyName("seriousAdverseOutcome")]
        public virtual MedicalEntity? SeriousAdverseOutcome { get; set; }

    }
}

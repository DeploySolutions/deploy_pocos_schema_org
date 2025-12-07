using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    public partial class DDxElement : MedicalIntangible
    {
        public DDxElement()
        {
            Type = "DDxElement";
        }

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
        [JsonPropertyName("diagnosis")]
        public virtual MedicalCondition? Diagnosis { get; set; }

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
        [JsonPropertyName("distinguishingSign")]
        public virtual MedicalSignOrSymptom? DistinguishingSign { get; set; }

    }
}

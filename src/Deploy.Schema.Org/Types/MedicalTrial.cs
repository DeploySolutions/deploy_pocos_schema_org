using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical trial is a type of medical study that uses a scientific process to compare the safety and efficacy of medical therapies or medical procedures. In general, medical trials are controlled and subjects are allocated at random to the different treatment and/or control groups.
    /// </summary>
    public partial class MedicalTrial : MedicalStudy
    {
        public MedicalTrial()
        {
            Type = "MedicalTrial";
        }

    /// <summary>
    /// A medical trial is a type of medical study that uses a scientific process to compare the safety and efficacy of medical therapies or medical procedures. In general, medical trials are controlled and subjects are allocated at random to the different treatment and/or control groups.
    /// </summary>
        [JsonPropertyName("trialDesign")]
        public virtual MedicalTrialDesign? TrialDesign { get; set; }

    }
}

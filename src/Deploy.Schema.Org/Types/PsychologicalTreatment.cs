using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A process of care relying upon counseling, dialogue and communication  aimed at improving a mental health condition without use of drugs.
    /// </summary>
    public partial class PsychologicalTreatment : TherapeuticProcedure
    {
        public PsychologicalTreatment()
        {
            Type = "PsychologicalTreatment";
        }

    }
}

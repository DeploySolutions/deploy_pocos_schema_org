using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    public partial class MedicalGuidelineContraindication : MedicalGuideline
    {
        public MedicalGuidelineContraindication()
        {
            Type = "MedicalGuidelineContraindication";
        }

    }
}

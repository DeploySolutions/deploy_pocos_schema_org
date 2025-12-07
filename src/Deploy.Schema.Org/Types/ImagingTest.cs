using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    public partial class ImagingTest : MedicalTest
    {
        public ImagingTest()
        {
            Type = "ImagingTest";
        }

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
        [JsonPropertyName("imagingTechnique")]
        public virtual MedicalImagingTechnique? ImagingTechnique { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes. Enumerated type.
    /// </summary>
    public partial class MedicalImagingTechnique : MedicalEnumeration
    {
        public MedicalImagingTechnique()
        {
            Type = "MedicalImagingTechnique";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    public partial class RadiationTherapy : MedicalTherapy
    {
        public RadiationTherapy()
        {
            Type = "RadiationTherapy";
        }

    }
}

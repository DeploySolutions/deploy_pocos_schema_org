using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// </summary>
    public partial class VitalSign : MedicalSign
    {
        public VitalSign()
        {
            Type = "VitalSign";
        }

    }
}

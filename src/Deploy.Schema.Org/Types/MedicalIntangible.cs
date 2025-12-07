using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// </summary>
    public partial class MedicalIntangible : MedicalEntity
    {
        public MedicalIntangible()
        {
            Type = "MedicalIntangible";
        }

    }
}

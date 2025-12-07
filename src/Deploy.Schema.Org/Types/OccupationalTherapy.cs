using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A treatment of people with physical, emotional, or social problems, using purposeful activity to help them overcome or learn to deal with their problems.
    /// </summary>
    public partial class OccupationalTherapy : MedicalTherapy
    {
        public OccupationalTherapy()
        {
            Type = "OccupationalTherapy";
        }

    }
}

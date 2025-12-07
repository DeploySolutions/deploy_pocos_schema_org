using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any specific branch of medical science or practice. Medical specialities include clinical specialties that pertain to particular organ systems and their respective disease states, as well as allied health specialties. Enumerated type.
    /// </summary>
    public partial class MedicalSpecialty : MedicalEnumeration
    {
        public MedicalSpecialty()
        {
            Type = "MedicalSpecialty";
        }

    }
}

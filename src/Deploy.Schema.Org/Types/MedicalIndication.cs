using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A condition or factor that indicates use of a medical therapy, including signs, symptoms, risk factors, anatomical states, etc.
    /// </summary>
    public partial class MedicalIndication : MedicalEntity
    {
        public MedicalIndication()
        {
            Type = "MedicalIndication";
        }

    }
}

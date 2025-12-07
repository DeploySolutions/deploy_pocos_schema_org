using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// </summary>
    public partial class PhysicalTherapy : MedicalTherapy
    {
        public PhysicalTherapy()
        {
            Type = "PhysicalTherapy";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Indicates whether this drug is available by prescription or over-the-counter.
    /// </summary>
    public partial class DrugPrescriptionStatus : MedicalEnumeration
    {
        public DrugPrescriptionStatus()
        {
            Type = "DrugPrescriptionStatus";
        }

    }
}

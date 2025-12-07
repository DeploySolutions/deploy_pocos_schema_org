using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Systems of medical practice.
    /// </summary>
    public partial class MedicineSystem : MedicalEnumeration
    {
        public MedicineSystem()
        {
            Type = "MedicineSystem";
        }

    }
}

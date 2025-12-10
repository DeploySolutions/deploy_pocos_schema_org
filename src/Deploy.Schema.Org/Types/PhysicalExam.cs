using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of physical examination of a patient performed by a physician.
    /// </summary>
    public partial class PhysicalExam : MedicalEnumeration
    {
        public PhysicalExam()
        {
            Type = "PhysicalExam";
        }

    }
}

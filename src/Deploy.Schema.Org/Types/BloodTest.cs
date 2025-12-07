using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    public partial class BloodTest : MedicalTest
    {
        public BloodTest()
        {
            Type = "BloodTest";
        }

    }
}

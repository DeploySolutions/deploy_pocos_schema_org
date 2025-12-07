using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// </summary>
    public partial class SurgicalProcedure : MedicalProcedure
    {
        public SurgicalProcedure()
        {
            Type = "SurgicalProcedure";
        }

    }
}

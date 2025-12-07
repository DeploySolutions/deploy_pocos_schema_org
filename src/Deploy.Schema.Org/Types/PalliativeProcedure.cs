using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// </summary>
    public partial class PalliativeProcedure : MedicalProcedure
    {
        public PalliativeProcedure()
        {
            Type = "PalliativeProcedure";
        }

    }
}

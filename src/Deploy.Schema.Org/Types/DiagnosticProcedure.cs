using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// </summary>
    public partial class DiagnosticProcedure : MedicalProcedure
    {
        public DiagnosticProcedure()
        {
            Type = "DiagnosticProcedure";
        }

    }
}

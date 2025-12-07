using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An enumeration that describes different types of medical procedures.
    /// </summary>
    public partial class MedicalProcedureType : MedicalEnumeration
    {
        public MedicalProcedureType()
        {
            Type = "MedicalProcedureType";
        }

    }
}

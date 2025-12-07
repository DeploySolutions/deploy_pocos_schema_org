using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A vet's office.
    /// </summary>
    public partial class VeterinaryCare : MedicalOrganization
    {
        public VeterinaryCare()
        {
            Type = "VeterinaryCare";
        }

    }
}

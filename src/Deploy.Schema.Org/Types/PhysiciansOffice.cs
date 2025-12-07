using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A doctor's office or clinic.
    /// </summary>
    public partial class PhysiciansOffice : Physician
    {
        public PhysiciansOffice()
        {
            Type = "PhysiciansOffice";
        }

    }
}

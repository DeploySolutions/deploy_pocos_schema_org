using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    public partial class Optician : MedicalBusiness
    {
        public Optician()
        {
            Type = "Optician";
        }

    }
}

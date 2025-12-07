using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A dentist.
    /// </summary>
    public partial class Dentist : LocalBusiness
    {
        public Dentist()
        {
            Type = "Dentist";
        }

    }
}

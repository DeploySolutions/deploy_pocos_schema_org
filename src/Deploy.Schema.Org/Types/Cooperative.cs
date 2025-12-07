using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An organization that is a joint project of multiple organizations or persons.
    /// </summary>
    public partial class Cooperative : Organization
    {
        public Cooperative()
        {
            Type = "Cooperative";
        }

    }
}

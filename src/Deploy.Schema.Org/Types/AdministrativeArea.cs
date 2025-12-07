using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    public partial class AdministrativeArea : Place
    {
        public AdministrativeArea()
        {
            Type = "AdministrativeArea";
        }

    }
}

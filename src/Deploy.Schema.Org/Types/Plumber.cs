using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A plumbing service.
    /// </summary>
    public partial class Plumber : HomeAndConstructionBusiness
    {
        public Plumber()
        {
            Type = "Plumber";
        }

    }
}

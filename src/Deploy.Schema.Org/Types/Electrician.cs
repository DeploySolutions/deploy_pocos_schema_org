using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An electrician.
    /// </summary>
    public partial class Electrician : HomeAndConstructionBusiness
    {
        public Electrician()
        {
            Type = "Electrician";
        }

    }
}

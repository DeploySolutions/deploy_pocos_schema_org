using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A locksmith.
    /// </summary>
    public partial class Locksmith : HomeAndConstructionBusiness
    {
        public Locksmith()
        {
            Type = "Locksmith";
        }

    }
}

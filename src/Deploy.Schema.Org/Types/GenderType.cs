using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An enumeration of genders.
    /// </summary>
    public partial class GenderType : Enumeration
    {
        public GenderType()
        {
            Type = "GenderType";
        }

    }
}

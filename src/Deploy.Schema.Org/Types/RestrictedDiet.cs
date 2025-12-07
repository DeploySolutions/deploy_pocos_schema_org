using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons. 
    /// </summary>
    public partial class RestrictedDiet : Enumeration
    {
        public RestrictedDiet()
        {
            Type = "RestrictedDiet";
        }

    }
}

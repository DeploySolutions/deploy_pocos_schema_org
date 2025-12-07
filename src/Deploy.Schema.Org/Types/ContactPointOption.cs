using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// </summary>
    public partial class ContactPointOption : Enumeration
    {
        public ContactPointOption()
        {
            Type = "ContactPointOption";
        }

    }
}

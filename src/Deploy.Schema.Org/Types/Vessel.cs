using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    public partial class Vessel : AnatomicalStructure
    {
        public Vessel()
        {
            Type = "Vessel";
        }

    }
}

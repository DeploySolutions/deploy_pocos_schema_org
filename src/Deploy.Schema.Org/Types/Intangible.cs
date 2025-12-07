using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// </summary>
    public partial class Intangible : Thing
    {
        public Intangible()
        {
            Type = "Intangible";
        }

    }
}

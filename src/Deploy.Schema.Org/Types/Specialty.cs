using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// </summary>
    public partial class Specialty : Enumeration
    {
        public Specialty()
        {
            Type = "Specialty";
        }

    }
}

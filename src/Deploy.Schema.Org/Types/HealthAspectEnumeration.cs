using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// HealthAspectEnumeration enumerates several aspects of health content online, each of which might be described using [[hasHealthAspect]] and [[HealthTopicContent]].
    /// </summary>
    public partial class HealthAspectEnumeration : Enumeration
    {
        public HealthAspectEnumeration()
        {
            Type = "HealthAspectEnumeration";
        }

    }
}

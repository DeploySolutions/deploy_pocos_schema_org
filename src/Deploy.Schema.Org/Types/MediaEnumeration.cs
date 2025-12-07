using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// MediaEnumeration enumerations are lists of codes, labels etc. useful for describing media objects. They may be reflections of externally developed lists, or created at schema.org, or a combination.
    /// </summary>
    public partial class MediaEnumeration : Enumeration
    {
        public MediaEnumeration()
        {
            Type = "MediaEnumeration";
        }

    }
}

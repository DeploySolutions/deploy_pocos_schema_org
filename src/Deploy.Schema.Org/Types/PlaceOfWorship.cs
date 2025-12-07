using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    public partial class PlaceOfWorship : CivicStructure
    {
        public PlaceOfWorship()
        {
            Type = "PlaceOfWorship";
        }

    }
}

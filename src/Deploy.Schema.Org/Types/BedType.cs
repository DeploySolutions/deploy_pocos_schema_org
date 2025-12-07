using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// </summary>
    public partial class BedType : QualitativeValue
    {
        public BedType()
        {
            Type = "BedType";
        }

    }
}

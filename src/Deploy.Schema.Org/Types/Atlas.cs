using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    public partial class Atlas : CreativeWork
    {
        public Atlas()
        {
            Type = "Atlas";
        }

    }
}

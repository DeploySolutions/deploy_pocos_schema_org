using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A publication containing information about varied topics that are pertinent to general information, a geographic area, or a specific subject matter (i.e. business, culture, education). Often published daily.
    /// </summary>
    public partial class Newspaper : Periodical
    {
        public Newspaper()
        {
            Type = "Newspaper";
        }

    }
}

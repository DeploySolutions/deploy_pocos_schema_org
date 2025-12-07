using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also [[CreativeWorkSeries]], [[EventSeries]].
    /// </summary>
    public partial class Series : Intangible
    {
        public Series()
        {
            Type = "Series";
        }

    }
}

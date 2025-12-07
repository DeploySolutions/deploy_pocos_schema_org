using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Quantity: Duration (use [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601)).
    /// </summary>
    public partial class Duration : Quantity
    {
        public Duration()
        {
            Type = "Duration";
        }

    }
}

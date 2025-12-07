using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Properties that take Distances as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Length unit of measure&amp;gt;'. E.g., '7 ft'.
    /// </summary>
    public partial class Distance : Quantity
    {
        public Distance()
        {
            Type = "Distance";
        }

    }
}

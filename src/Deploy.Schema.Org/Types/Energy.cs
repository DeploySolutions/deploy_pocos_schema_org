using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.
    /// </summary>
    public partial class Energy : Quantity
    {
        public Energy()
        {
            Type = "Energy";
        }

    }
}

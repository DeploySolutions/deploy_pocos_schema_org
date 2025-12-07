using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Properties that take Mass as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Mass unit of measure&amp;gt;'. E.g., '7 kg'.
    /// </summary>
    public partial class Mass : Quantity
    {
        public Mass()
        {
            Type = "Mass";
        }

    }
}

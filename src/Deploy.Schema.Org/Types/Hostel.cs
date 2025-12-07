using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A hostel - cheap accommodation, often in shared dormitories.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
    public partial class Hostel : LodgingBusiness
    {
        public Hostel()
        {
            Type = "Hostel";
        }

    }
}

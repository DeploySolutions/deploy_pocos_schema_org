using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Room"&gt;http://en.wikipedia.org/wiki/Room&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
    public partial class Room : Accommodation
    {
        public Room()
        {
            Type = "Room";
        }

    }
}

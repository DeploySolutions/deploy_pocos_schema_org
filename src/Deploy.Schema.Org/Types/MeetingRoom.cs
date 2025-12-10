using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// 
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial class MeetingRoom : Room
    {
        public MeetingRoom()
        {
            Type = "MeetingRoom";
        }

    }
}

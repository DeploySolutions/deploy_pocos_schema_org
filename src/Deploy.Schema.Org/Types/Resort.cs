using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishments operated by a single company (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Resort"&gt;http://en.wikipedia.org/wiki/Resort&lt;/a&gt;).
    /// 
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial class Resort : LodgingBusiness
    {
        public Resort()
        {
            Type = "Resort";
        }

    }
}

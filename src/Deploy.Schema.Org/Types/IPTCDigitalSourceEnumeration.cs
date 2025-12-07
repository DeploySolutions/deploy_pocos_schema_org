using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// &lt;a href="https://www.iptc.org/"&gt;IPTC&lt;/a&gt; "Digital Source" codes for use with the [[digitalSourceType]] property, providing information about the source for a digital media object.
    /// In general these codes are not declared here to be mutually exclusive, although some combinations would be contradictory if applied simultaneously, or might be considered mutually incompatible by upstream maintainers of the definitions. See the IPTC &lt;a href="https://www.iptc.org/std/photometadata/documentation/userguide/"&gt;documentation&lt;/a&gt;
    ///  for &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;detailed definitions&lt;/a&gt; of all terms.
    /// </summary>
    public partial class IPTCDigitalSourceEnumeration : MediaEnumeration
    {
        public IPTCDigitalSourceEnumeration()
        {
            Type = "IPTCDigitalSourceEnumeration";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates common size systems for different categories of products, for example "EN-13402" or "UK" for wearables or "Imperial" for screws.
    /// </summary>
    public partial class SizeSystemEnumeration : Enumeration
    {
        public SizeSystemEnumeration()
        {
            Type = "SizeSystemEnumeration";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A list of possible product availability options.
    /// </summary>
    public partial class ItemAvailability : Enumeration
    {
        public ItemAvailability()
        {
            Type = "ItemAvailability";
        }

    }
}

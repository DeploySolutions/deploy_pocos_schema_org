using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A convenience store.
    /// </summary>
    public partial class ConvenienceStore : Store
    {
        public ConvenienceStore()
        {
            Type = "ConvenienceStore";
        }

    }
}

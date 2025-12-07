using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A men's clothing store.
    /// </summary>
    public partial class MensClothingStore : Store
    {
        public MensClothingStore()
        {
            Type = "MensClothingStore";
        }

    }
}

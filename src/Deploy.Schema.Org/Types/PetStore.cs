using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A pet store.
    /// </summary>
    public partial class PetStore : Store
    {
        public PetStore()
        {
            Type = "PetStore";
        }

    }
}

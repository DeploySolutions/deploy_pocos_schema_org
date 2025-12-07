using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    public partial class HobbyShop : Store
    {
        public HobbyShop()
        {
            Type = "HobbyShop";
        }

    }
}

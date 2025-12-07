using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A jewelry store.
    /// </summary>
    public partial class JewelryStore : Store
    {
        public JewelryStore()
        {
            Type = "JewelryStore";
        }

    }
}

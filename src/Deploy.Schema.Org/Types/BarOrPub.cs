using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bar or pub.
    /// </summary>
    public partial class BarOrPub : FoodEstablishment
    {
        public BarOrPub()
        {
            Type = "BarOrPub";
        }

    }
}

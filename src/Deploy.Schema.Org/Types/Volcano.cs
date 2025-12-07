using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A volcano, like Fujisan.
    /// </summary>
    public partial class Volcano : Landform
    {
        public Volcano()
        {
            Type = "Volcano";
        }

    }
}

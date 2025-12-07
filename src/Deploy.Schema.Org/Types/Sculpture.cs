using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    public partial class Sculpture : CreativeWork
    {
        public Sculpture()
        {
            Type = "Sculpture";
        }

    }
}

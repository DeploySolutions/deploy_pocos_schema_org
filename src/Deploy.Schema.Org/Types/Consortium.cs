using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Consortium is a membership [[Organization]] whose members are typically Organizations.
    /// </summary>
    public partial class Consortium : Organization
    {
        public Consortium()
        {
            Type = "Consortium";
        }

    }
}

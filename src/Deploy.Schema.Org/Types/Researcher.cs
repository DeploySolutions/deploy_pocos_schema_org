using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Researchers.
    /// </summary>
    public partial class Researcher : Audience
    {
        public Researcher()
        {
            Type = "Researcher";
        }

    }
}

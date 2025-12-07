using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Research project.
    /// </summary>
    public partial class ResearchProject : Project
    {
        public ResearchProject()
        {
            Type = "ResearchProject";
        }

    }
}

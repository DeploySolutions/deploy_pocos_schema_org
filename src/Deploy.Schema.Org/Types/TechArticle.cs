using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    public partial class TechArticle : Article
    {
        public TechArticle()
        {
            Type = "TechArticle";
        }

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
        [JsonPropertyName("dependencies")]
        public virtual string? Dependencies { get; set; }

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
        [JsonPropertyName("proficiencyLevel")]
        public virtual string? ProficiencyLevel { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    public partial class APIReference : TechArticle
    {
        public APIReference()
        {
            Type = "APIReference";
        }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
        [JsonPropertyName("assembly")]
        public virtual string? Assembly { get; set; }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
        [JsonPropertyName("assemblyVersion")]
        public virtual string? AssemblyVersion { get; set; }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
        [JsonPropertyName("executableLibraryName")]
        public virtual string? ExecutableLibraryName { get; set; }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
        [JsonPropertyName("programmingModel")]
        public virtual string? ProgrammingModel { get; set; }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
        [JsonPropertyName("targetPlatform")]
        public virtual string? TargetPlatform { get; set; }

    }
}

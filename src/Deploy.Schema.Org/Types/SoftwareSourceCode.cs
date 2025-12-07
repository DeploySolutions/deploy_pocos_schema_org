using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    public partial class SoftwareSourceCode : CreativeWork
    {
        public SoftwareSourceCode()
        {
            Type = "SoftwareSourceCode";
        }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("codeRepository")]
        public virtual string? CodeRepository { get; set; }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("codeSampleType")]
        public virtual string? CodeSampleType { get; set; }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("programmingLanguage")]
        public virtual object? ProgrammingLanguage { get; set; }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("runtime")]
        public virtual string? Runtime { get; set; }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("runtimePlatform")]
        public virtual string? RuntimePlatform { get; set; }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("sampleType")]
        public virtual string? SampleType { get; set; }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
        [JsonPropertyName("targetProduct")]
        public virtual SoftwareApplication? TargetProduct { get; set; }

    }
}

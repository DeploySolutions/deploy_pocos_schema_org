using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A software application.
    /// </summary>
    public partial class SoftwareApplication : CreativeWork
    {
        public SoftwareApplication()
        {
            Type = "SoftwareApplication";
        }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("applicationCategory")]
        public virtual object? ApplicationCategory { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("applicationSubCategory")]
        public virtual object? ApplicationSubCategory { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("applicationSuite")]
        public virtual string? ApplicationSuite { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("availableOnDevice")]
        public virtual string? AvailableOnDevice { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("countriesNotSupported")]
        public virtual string? CountriesNotSupported { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("countriesSupported")]
        public virtual string? CountriesSupported { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("device")]
        public virtual string? Device { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("downloadUrl")]
        public virtual string? DownloadUrl { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("featureList")]
        public virtual object? FeatureList { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("fileSize")]
        public virtual string? FileSize { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("installUrl")]
        public virtual string? InstallUrl { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("memoryRequirements")]
        public virtual object? MemoryRequirements { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("operatingSystem")]
        public virtual string? OperatingSystem { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("permissions")]
        public virtual string? Permissions { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("processorRequirements")]
        public virtual string? ProcessorRequirements { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("releaseNotes")]
        public virtual object? ReleaseNotes { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("requirements")]
        public virtual object? Requirements { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("screenshot")]
        public virtual object? Screenshot { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("softwareAddOn")]
        public virtual SoftwareApplication? SoftwareAddOn { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("softwareHelp")]
        public virtual CreativeWork? SoftwareHelp { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("softwareRequirements")]
        public virtual object? SoftwareRequirements { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("softwareVersion")]
        public virtual string? SoftwareVersion { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("storageRequirements")]
        public virtual object? StorageRequirements { get; set; }

    /// <summary>
    /// A software application.
    /// </summary>
        [JsonPropertyName("supportingData")]
        public virtual DataFeed? SupportingData { get; set; }

    }
}

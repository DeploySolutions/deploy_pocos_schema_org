using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
    public partial class MedicalWebPage : WebPage
    {
        public MedicalWebPage()
        {
            Type = "MedicalWebPage";
        }

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
        [JsonPropertyName("aspect")]
        public virtual string? Aspect { get; set; }

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
        [JsonPropertyName("medicalAudience")]
        public virtual object? MedicalAudience { get; set; }

    }
}

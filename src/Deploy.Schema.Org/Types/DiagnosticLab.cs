using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
    public partial class DiagnosticLab : MedicalOrganization
    {
        public DiagnosticLab()
        {
            Type = "DiagnosticLab";
        }

    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
        [JsonPropertyName("availableTest")]
        public virtual MedicalTest? AvailableTest { get; set; }

    }
}

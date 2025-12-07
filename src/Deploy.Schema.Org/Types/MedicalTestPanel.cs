using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    public partial class MedicalTestPanel : MedicalTest
    {
        public MedicalTestPanel()
        {
            Type = "MedicalTestPanel";
        }

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
        [JsonPropertyName("subTest")]
        public virtual MedicalTest? SubTest { get; set; }

    }
}

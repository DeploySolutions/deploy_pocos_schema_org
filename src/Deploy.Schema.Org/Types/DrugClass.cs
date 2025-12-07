using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A class of medical drugs, e.g., statins. Classes can represent general pharmacological class, common mechanisms of action, common physiological effects, etc.
    /// </summary>
    public partial class DrugClass : MedicalEntity
    {
        public DrugClass()
        {
            Type = "DrugClass";
        }

    /// <summary>
    /// A class of medical drugs, e.g., statins. Classes can represent general pharmacological class, common mechanisms of action, common physiological effects, etc.
    /// </summary>
        [JsonPropertyName("drug")]
        public virtual Drug? Drug { get; set; }

    }
}

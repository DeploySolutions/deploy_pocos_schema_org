using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A SpeakableSpecification indicates (typically via [[xpath]] or [[cssSelector]]) sections of a document that are highlighted as particularly [[speakable]]. Instances of this type are expected to be used primarily as values of the [[speakable]] property.
    /// </summary>
    public partial class SpeakableSpecification : Intangible
    {
        public SpeakableSpecification()
        {
            Type = "SpeakableSpecification";
        }

    /// <summary>
    /// A SpeakableSpecification indicates (typically via [[xpath]] or [[cssSelector]]) sections of a document that are highlighted as particularly [[speakable]]. Instances of this type are expected to be used primarily as values of the [[speakable]] property.
    /// </summary>
        [JsonPropertyName("cssSelector")]
        public virtual CssSelectorType? CssSelector { get; set; }

    /// <summary>
    /// A SpeakableSpecification indicates (typically via [[xpath]] or [[cssSelector]]) sections of a document that are highlighted as particularly [[speakable]]. Instances of this type are expected to be used primarily as values of the [[speakable]] property.
    /// </summary>
        [JsonPropertyName("xpath")]
        public virtual XPathType? Xpath { get; set; }

    }
}

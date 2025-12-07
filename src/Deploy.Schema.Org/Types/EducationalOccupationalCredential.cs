using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
    public partial class EducationalOccupationalCredential : CreativeWork
    {
        public EducationalOccupationalCredential()
        {
            Type = "EducationalOccupationalCredential";
        }

    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
        [JsonPropertyName("competencyRequired")]
        public virtual object? CompetencyRequired { get; set; }

    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
        [JsonPropertyName("credentialCategory")]
        public virtual object? CredentialCategory { get; set; }

    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
        [JsonPropertyName("educationalLevel")]
        public virtual object? EducationalLevel { get; set; }

    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
        [JsonPropertyName("recognizedBy")]
        public virtual Organization? RecognizedBy { get; set; }

    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
        [JsonPropertyName("validFor")]
        public virtual Duration? ValidFor { get; set; }

    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// </summary>
        [JsonPropertyName("validIn")]
        public virtual AdministrativeArea? ValidIn { get; set; }

    }
}

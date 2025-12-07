using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    public partial class OrganizationRole : Role
    {
        public OrganizationRole()
        {
            Type = "OrganizationRole";
        }

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
        [JsonPropertyName("numberedPosition")]
        public virtual double? NumberedPosition { get; set; }

    }
}

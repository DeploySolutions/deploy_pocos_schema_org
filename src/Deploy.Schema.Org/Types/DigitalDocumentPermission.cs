using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    public partial class DigitalDocumentPermission : Intangible
    {
        public DigitalDocumentPermission()
        {
            Type = "DigitalDocumentPermission";
        }

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
        [JsonPropertyName("grantee")]
        public virtual object? Grantee { get; set; }

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
        [JsonPropertyName("permissionType")]
        public virtual DigitalDocumentPermissionType? PermissionType { get; set; }

    }
}

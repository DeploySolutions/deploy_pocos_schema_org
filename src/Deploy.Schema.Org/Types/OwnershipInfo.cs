using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    public partial class OwnershipInfo : StructuredValue
    {
        public OwnershipInfo()
        {
            Type = "OwnershipInfo";
        }

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
        [JsonPropertyName("acquiredFrom")]
        public virtual object? AcquiredFrom { get; set; }

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
        [JsonPropertyName("ownedFrom")]
        public virtual DateTime? OwnedFrom { get; set; }

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
        [JsonPropertyName("ownedThrough")]
        public virtual DateTime? OwnedThrough { get; set; }

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
        [JsonPropertyName("typeOfGood")]
        public virtual object? TypeOfGood { get; set; }

    }
}

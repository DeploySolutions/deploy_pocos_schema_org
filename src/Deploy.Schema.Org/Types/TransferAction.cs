using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
    public partial class TransferAction : Action
    {
        public TransferAction()
        {
            Type = "TransferAction";
        }

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
        [JsonPropertyName("fromLocation")]
        public virtual Place? FromLocation { get; set; }

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
        [JsonPropertyName("toLocation")]
        public virtual Place? ToLocation { get; set; }

    }
}

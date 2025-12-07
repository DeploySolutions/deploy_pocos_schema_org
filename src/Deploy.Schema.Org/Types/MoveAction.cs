using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of an agent relocating to a place.\n\nRelated actions:\n\n* [[TransferAction]]: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.
    /// </summary>
    public partial class MoveAction : Action
    {
        public MoveAction()
        {
            Type = "MoveAction";
        }

    /// <summary>
    /// The act of an agent relocating to a place.\n\nRelated actions:\n\n* [[TransferAction]]: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.
    /// </summary>
        [JsonPropertyName("fromLocation")]
        public virtual Place? FromLocation { get; set; }

    /// <summary>
    /// The act of an agent relocating to a place.\n\nRelated actions:\n\n* [[TransferAction]]: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.
    /// </summary>
        [JsonPropertyName("toLocation")]
        public virtual Place? ToLocation { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.\n\nRelated actions:\n\n* [[LendAction]]: Reciprocal of BorrowAction.
    /// </summary>
    public partial class BorrowAction : TransferAction
    {
        public BorrowAction()
        {
            Type = "BorrowAction";
        }

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.\n\nRelated actions:\n\n* [[LendAction]]: Reciprocal of BorrowAction.
    /// </summary>
        [JsonPropertyName("lender")]
        public virtual object? Lender { get; set; }

    }
}

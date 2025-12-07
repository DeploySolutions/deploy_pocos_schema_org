using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.\n\nRelated actions:\n\n* [[BorrowAction]]: Reciprocal of LendAction.
    /// </summary>
    public partial class LendAction : TransferAction
    {
        public LendAction()
        {
            Type = "LendAction";
        }

    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.\n\nRelated actions:\n\n* [[BorrowAction]]: Reciprocal of LendAction.
    /// </summary>
        [JsonPropertyName("borrower")]
        public virtual Person? Borrower { get; set; }

    }
}

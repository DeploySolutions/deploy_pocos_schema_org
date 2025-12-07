using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of transferring money from one place to another place. This may occur electronically or physically.
    /// </summary>
    public partial class MoneyTransfer : TransferAction
    {
        public MoneyTransfer()
        {
            Type = "MoneyTransfer";
        }

    /// <summary>
    /// The act of transferring money from one place to another place. This may occur electronically or physically.
    /// </summary>
        [JsonPropertyName("amount")]
        public virtual object? Amount { get; set; }

    /// <summary>
    /// The act of transferring money from one place to another place. This may occur electronically or physically.
    /// </summary>
        [JsonPropertyName("beneficiaryBank")]
        public virtual object? BeneficiaryBank { get; set; }

    }
}

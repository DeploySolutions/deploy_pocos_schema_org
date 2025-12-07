using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A loan in which property or real estate is used as collateral. (A loan securitized against some real estate.)
    /// </summary>
    public partial class MortgageLoan : LoanOrCredit
    {
        public MortgageLoan()
        {
            Type = "MortgageLoan";
        }

    /// <summary>
    /// A loan in which property or real estate is used as collateral. (A loan securitized against some real estate.)
    /// </summary>
        [JsonPropertyName("domiciledMortgage")]
        public virtual bool? DomiciledMortgage { get; set; }

    /// <summary>
    /// A loan in which property or real estate is used as collateral. (A loan securitized against some real estate.)
    /// </summary>
        [JsonPropertyName("loanMortgageMandateAmount")]
        public virtual MonetaryAmount? LoanMortgageMandateAmount { get; set; }

    }
}

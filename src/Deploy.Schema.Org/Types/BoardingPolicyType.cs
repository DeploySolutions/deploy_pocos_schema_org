using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of boarding policy used by an airline.
    /// </summary>
    public partial class BoardingPolicyType : Enumeration
    {
        public BoardingPolicyType()
        {
            Type = "BoardingPolicyType";
        }

    }
}

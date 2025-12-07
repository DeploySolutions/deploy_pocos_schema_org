using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A notary.
    /// </summary>
    public partial class Notary : LegalService
    {
        public Notary()
        {
            Type = "Notary";
        }

    }
}

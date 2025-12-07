using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Professional service: Attorney. \n\nThis type is deprecated - [[LegalService]] is more inclusive and less ambiguous.
    /// </summary>
    public partial class Attorney : LegalService
    {
        public Attorney()
        {
            Type = "Attorney";
        }

    }
}

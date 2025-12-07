using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    public partial class DefenceEstablishment : GovernmentBuilding
    {
        public DefenceEstablishment()
        {
            Type = "DefenceEstablishment";
        }

    }
}

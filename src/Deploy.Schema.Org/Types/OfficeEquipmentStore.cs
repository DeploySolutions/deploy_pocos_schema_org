using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An office equipment store.
    /// </summary>
    public partial class OfficeEquipmentStore : Store
    {
        public OfficeEquipmentStore()
        {
            Type = "OfficeEquipmentStore";
        }

    }
}

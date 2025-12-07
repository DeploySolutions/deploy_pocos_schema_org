using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A department store.
    /// </summary>
    public partial class DepartmentStore : Store
    {
        public DepartmentStore()
        {
            Type = "DepartmentStore";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A computer store.
    /// </summary>
    public partial class ComputerStore : Store
    {
        public ComputerStore()
        {
            Type = "ComputerStore";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    public partial class FMRadioChannel : RadioChannel
    {
        public FMRadioChannel()
        {
            Type = "FMRadioChannel";
        }

    }
}

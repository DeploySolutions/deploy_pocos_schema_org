using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A radio channel that uses AM.
    /// </summary>
    public partial class AMRadioChannel : RadioChannel
    {
        public AMRadioChannel()
        {
            Type = "AMRadioChannel";
        }

    }
}

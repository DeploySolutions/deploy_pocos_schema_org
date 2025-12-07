using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    public partial class DownloadAction : TransferAction
    {
        public DownloadAction()
        {
            Type = "DownloadAction";
        }

    }
}

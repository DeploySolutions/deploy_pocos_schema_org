using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[comment]] that corrects [[CreativeWork]].
    /// </summary>
    public partial class CorrectionComment : Comment
    {
        public CorrectionComment()
        {
            Type = "CorrectionComment";
        }

    }
}

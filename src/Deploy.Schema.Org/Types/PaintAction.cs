using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// </summary>
    public partial class PaintAction : CreateAction
    {
        public PaintAction()
        {
            Type = "PaintAction";
        }

    }
}

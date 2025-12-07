using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// </summary>
    public partial class DrawAction : CreateAction
    {
        public DrawAction()
        {
            Type = "DrawAction";
        }

    }
}

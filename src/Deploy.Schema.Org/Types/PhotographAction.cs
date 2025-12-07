using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    public partial class PhotographAction : CreateAction
    {
        public PhotographAction()
        {
            Type = "PhotographAction";
        }

    }
}

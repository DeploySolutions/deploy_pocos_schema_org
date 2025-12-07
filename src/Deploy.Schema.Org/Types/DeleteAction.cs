using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    public partial class DeleteAction : UpdateAction
    {
        public DeleteAction()
        {
            Type = "DeleteAction";
        }

    }
}

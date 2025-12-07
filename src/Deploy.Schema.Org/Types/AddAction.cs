using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    public partial class AddAction : UpdateAction
    {
        public AddAction()
        {
            Type = "AddAction";
        }

    }
}

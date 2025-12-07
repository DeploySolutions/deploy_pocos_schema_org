using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// </summary>
    public partial class AppendAction : InsertAction
    {
        public AppendAction()
        {
            Type = "AppendAction";
        }

    }
}

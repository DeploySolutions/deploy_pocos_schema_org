using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    public partial class PrependAction : InsertAction
    {
        public PrependAction()
        {
            Type = "PrependAction";
        }

    }
}

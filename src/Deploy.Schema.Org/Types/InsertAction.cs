using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    public partial class InsertAction : AddAction
    {
        public InsertAction()
        {
            Type = "InsertAction";
        }

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
        [JsonPropertyName("toLocation")]
        public virtual Place? ToLocation { get; set; }

    }
}

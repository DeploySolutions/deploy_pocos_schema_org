using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A StupidType for testing.
    /// </summary>
    public partial class StupidType : Thing
    {
        public StupidType()
        {
            Type = "StupidType";
        }

    /// <summary>
    /// A StupidType for testing.
    /// </summary>
        [JsonPropertyName("stupidProperty")]
        public virtual QuantitativeValue? StupidProperty { get; set; }

    }
}

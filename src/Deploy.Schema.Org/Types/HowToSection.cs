using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
    public partial class HowToSection : CreativeWork
    {
        public HowToSection()
        {
            Type = "HowToSection";
        }

    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
        [JsonPropertyName("steps")]
        public virtual object? Steps { get; set; }

    }
}

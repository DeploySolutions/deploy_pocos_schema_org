using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A math solver which is capable of solving a subset of mathematical problems.
    /// </summary>
    public partial class MathSolver : CreativeWork
    {
        public MathSolver()
        {
            Type = "MathSolver";
        }

    /// <summary>
    /// A math solver which is capable of solving a subset of mathematical problems.
    /// </summary>
        [JsonPropertyName("mathExpression")]
        public virtual object? MathExpression { get; set; }

    }
}

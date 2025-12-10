using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The ConstraintNode type is provided to support usecases in which a node in a structured data graph is described with properties which appear to describe a single entity, but are being used in a situation where they serve a more abstract purpose. A [[ConstraintNode]] can be described using [[constraintProperty]] and [[numConstraints]]. These constraint properties can serve a
    /// variety of purposes, and their values may sometimes be understood to indicate sets of possible values rather than single, exact and specific values.
    /// </summary>
    public partial class ConstraintNode : Intangible
    {
        public ConstraintNode()
        {
            Type = "ConstraintNode";
        }

    /// <summary>
    /// The ConstraintNode type is provided to support usecases in which a node in a structured data graph is described with properties which appear to describe a single entity, but are being used in a situation where they serve a more abstract purpose. A [[ConstraintNode]] can be described using [[constraintProperty]] and [[numConstraints]]. These constraint properties can serve a
    /// variety of purposes, and their values may sometimes be understood to indicate sets of possible values rather than single, exact and specific values.
    /// </summary>
        [JsonPropertyName("constraintProperty")]
        public virtual object? ConstraintProperty { get; set; }

    /// <summary>
    /// The ConstraintNode type is provided to support usecases in which a node in a structured data graph is described with properties which appear to describe a single entity, but are being used in a situation where they serve a more abstract purpose. A [[ConstraintNode]] can be described using [[constraintProperty]] and [[numConstraints]]. These constraint properties can serve a
    /// variety of purposes, and their values may sometimes be understood to indicate sets of possible values rather than single, exact and specific values.
    /// </summary>
        [JsonPropertyName("numConstraints")]
        public virtual Integer? NumConstraints { get; set; }

    }
}

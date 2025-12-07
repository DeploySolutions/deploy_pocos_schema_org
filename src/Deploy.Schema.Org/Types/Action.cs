using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
    public partial class Action : Thing
    {
        public Action()
        {
            Type = "Action";
        }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("actionProcess")]
        public virtual HowTo? ActionProcess { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("actionStatus")]
        public virtual ActionStatusType? ActionStatus { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("agent")]
        public virtual object? Agent { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("endTime")]
        public virtual object? EndTime { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("error")]
        public virtual Thing? Error { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("instrument")]
        public virtual Thing? Instrument { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("location")]
        public virtual object? Location { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("object")]
        public virtual Thing? Object { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("participant")]
        public virtual object? Participant { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("result")]
        public virtual Thing? Result { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("startTime")]
        public virtual object? StartTime { get; set; }

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// </summary>
        [JsonPropertyName("target")]
        public virtual object? Target { get; set; }

    }
}

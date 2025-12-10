using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    /// </summary>
    public partial class OpeningHoursSpecification : StructuredValue
    {
        public OpeningHoursSpecification()
        {
            Type = "OpeningHoursSpecification";
        }

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    /// </summary>
        [JsonPropertyName("closes")]
        public virtual TimeSpan? Closes { get; set; }

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    /// </summary>
        [JsonPropertyName("dayOfWeek")]
        public virtual DayOfWeek? DayOfWeek { get; set; }

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    /// </summary>
        [JsonPropertyName("opens")]
        public virtual TimeSpan? Opens { get; set; }

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    /// </summary>
        [JsonPropertyName("validFrom")]
        public virtual object? ValidFrom { get; set; }

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    /// </summary>
        [JsonPropertyName("validThrough")]
        public virtual object? ValidThrough { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
    public partial class Event : Thing
    {
        public Event()
        {
            Type = "Event";
        }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("about")]
        public virtual Thing? About { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("attendee")]
        public virtual object? Attendee { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("attendees")]
        public virtual object? Attendees { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("audience")]
        public virtual Audience? Audience { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("composer")]
        public virtual object? Composer { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("contributor")]
        public virtual object? Contributor { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("doorTime")]
        public virtual object? DoorTime { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("endDate")]
        public virtual object? EndDate { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("eventAttendanceMode")]
        public virtual EventAttendanceModeEnumeration? EventAttendanceMode { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("eventSchedule")]
        public virtual Schedule? EventSchedule { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("eventStatus")]
        public virtual EventStatusType? EventStatus { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("funder")]
        public virtual object? Funder { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("inLanguage")]
        public virtual object? InLanguage { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("isAccessibleForFree")]
        public virtual bool? IsAccessibleForFree { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("keywords")]
        public virtual object? Keywords { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("location")]
        public virtual object? Location { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("maximumAttendeeCapacity")]
        public virtual Integer? MaximumAttendeeCapacity { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("maximumPhysicalAttendeeCapacity")]
        public virtual Integer? MaximumPhysicalAttendeeCapacity { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("maximumVirtualAttendeeCapacity")]
        public virtual Integer? MaximumVirtualAttendeeCapacity { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("organizer")]
        public virtual object? Organizer { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("performer")]
        public virtual object? Performer { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("performers")]
        public virtual object? Performers { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("previousStartDate")]
        public virtual DateTime? PreviousStartDate { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("recordedIn")]
        public virtual CreativeWork? RecordedIn { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("remainingAttendeeCapacity")]
        public virtual Integer? RemainingAttendeeCapacity { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("sponsor")]
        public virtual object? Sponsor { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("startDate")]
        public virtual object? StartDate { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("subEvent")]
        public virtual Event? SubEvent { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("subEvents")]
        public virtual Event? SubEvents { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("superEvent")]
        public virtual Event? SuperEvent { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("translator")]
        public virtual object? Translator { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("typicalAgeRange")]
        public virtual string? TypicalAgeRange { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("workFeatured")]
        public virtual CreativeWork? WorkFeatured { get; set; }

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// </summary>
        [JsonPropertyName("workPerformed")]
        public virtual CreativeWork? WorkPerformed { get; set; }

    }
}

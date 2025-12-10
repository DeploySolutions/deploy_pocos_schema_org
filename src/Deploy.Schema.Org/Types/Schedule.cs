using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
    public partial class Schedule : Intangible
    {
        public Schedule()
        {
            Type = "Schedule";
        }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("byDay")]
        public virtual object? ByDay { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("byMonth")]
        public virtual Integer? ByMonth { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("byMonthDay")]
        public virtual Integer? ByMonthDay { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("byMonthWeek")]
        public virtual Integer? ByMonthWeek { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("endDate")]
        public virtual object? EndDate { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("endTime")]
        public virtual object? EndTime { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("exceptDate")]
        public virtual object? ExceptDate { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("repeatCount")]
        public virtual Integer? RepeatCount { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("repeatFrequency")]
        public virtual object? RepeatFrequency { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("scheduleTimezone")]
        public virtual string? ScheduleTimezone { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("startDate")]
        public virtual object? StartDate { get; set; }

    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    /// This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    /// have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
        [JsonPropertyName("startTime")]
        public virtual object? StartTime { get; set; }

    }
}

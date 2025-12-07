using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
    public partial class Course : CreativeWork
    {
        public Course()
        {
            Type = "Course";
        }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("availableLanguage")]
        public virtual object? AvailableLanguage { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("courseCode")]
        public virtual string? CourseCode { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("coursePrerequisites")]
        public virtual object? CoursePrerequisites { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("educationalCredentialAwarded")]
        public virtual object? EducationalCredentialAwarded { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("financialAidEligible")]
        public virtual object? FinancialAidEligible { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("hasCourseInstance")]
        public virtual CourseInstance? HasCourseInstance { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("numberOfCredits")]
        public virtual object? NumberOfCredits { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("occupationalCredentialAwarded")]
        public virtual object? OccupationalCredentialAwarded { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("syllabusSections")]
        public virtual Syllabus? SyllabusSections { get; set; }

    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// </summary>
        [JsonPropertyName("totalHistoricalEnrollment")]
        public virtual Integer? TotalHistoricalEnrollment { get; set; }

    }
}

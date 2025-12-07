using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
    public partial class EducationalOccupationalProgram : Intangible
    {
        public EducationalOccupationalProgram()
        {
            Type = "EducationalOccupationalProgram";
        }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("applicationDeadline")]
        public virtual object? ApplicationDeadline { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("applicationStartDate")]
        public virtual DateTime? ApplicationStartDate { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("dayOfWeek")]
        public virtual DayOfWeek? DayOfWeek { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("educationalCredentialAwarded")]
        public virtual object? EducationalCredentialAwarded { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("educationalProgramMode")]
        public virtual object? EducationalProgramMode { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("endDate")]
        public virtual object? EndDate { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("financialAidEligible")]
        public virtual object? FinancialAidEligible { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("hasCourse")]
        public virtual Course? HasCourse { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("maximumEnrollment")]
        public virtual Integer? MaximumEnrollment { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("numberOfCredits")]
        public virtual object? NumberOfCredits { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("occupationalCategory")]
        public virtual object? OccupationalCategory { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("occupationalCredentialAwarded")]
        public virtual object? OccupationalCredentialAwarded { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("programPrerequisites")]
        public virtual object? ProgramPrerequisites { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("programType")]
        public virtual object? ProgramType { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("salaryUponCompletion")]
        public virtual MonetaryAmountDistribution? SalaryUponCompletion { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("startDate")]
        public virtual object? StartDate { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("termDuration")]
        public virtual Duration? TermDuration { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("termsPerYear")]
        public virtual double? TermsPerYear { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("timeOfDay")]
        public virtual string? TimeOfDay { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("timeToComplete")]
        public virtual Duration? TimeToComplete { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("trainingSalary")]
        public virtual MonetaryAmountDistribution? TrainingSalary { get; set; }

    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// </summary>
        [JsonPropertyName("typicalCreditsPerTerm")]
        public virtual object? TypicalCreditsPerTerm { get; set; }

    }
}

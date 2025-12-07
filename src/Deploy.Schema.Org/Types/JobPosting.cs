using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    public partial class JobPosting : Intangible
    {
        public JobPosting()
        {
            Type = "JobPosting";
        }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("applicantLocationRequirements")]
        public virtual AdministrativeArea? ApplicantLocationRequirements { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("applicationContact")]
        public virtual ContactPoint? ApplicationContact { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("baseSalary")]
        public virtual object? BaseSalary { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("benefits")]
        public virtual string? Benefits { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("datePosted")]
        public virtual object? DatePosted { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("directApply")]
        public virtual bool? DirectApply { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("educationRequirements")]
        public virtual object? EducationRequirements { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("eligibilityToWorkRequirement")]
        public virtual string? EligibilityToWorkRequirement { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("employerOverview")]
        public virtual string? EmployerOverview { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("employmentType")]
        public virtual string? EmploymentType { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("employmentUnit")]
        public virtual Organization? EmploymentUnit { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("estimatedSalary")]
        public virtual object? EstimatedSalary { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("experienceInPlaceOfEducation")]
        public virtual bool? ExperienceInPlaceOfEducation { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("experienceRequirements")]
        public virtual object? ExperienceRequirements { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("hiringOrganization")]
        public virtual object? HiringOrganization { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("incentiveCompensation")]
        public virtual string? IncentiveCompensation { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("incentives")]
        public virtual string? Incentives { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("industry")]
        public virtual object? Industry { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("jobBenefits")]
        public virtual string? JobBenefits { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("jobImmediateStart")]
        public virtual bool? JobImmediateStart { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("jobLocation")]
        public virtual Place? JobLocation { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("jobLocationType")]
        public virtual string? JobLocationType { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("jobStartDate")]
        public virtual object? JobStartDate { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("occupationalCategory")]
        public virtual object? OccupationalCategory { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("physicalRequirement")]
        public virtual object? PhysicalRequirement { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("qualifications")]
        public virtual object? Qualifications { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("relevantOccupation")]
        public virtual Occupation? RelevantOccupation { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("responsibilities")]
        public virtual string? Responsibilities { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("salaryCurrency")]
        public virtual string? SalaryCurrency { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("securityClearanceRequirement")]
        public virtual object? SecurityClearanceRequirement { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("sensoryRequirement")]
        public virtual object? SensoryRequirement { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("skills")]
        public virtual object? Skills { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("specialCommitments")]
        public virtual string? SpecialCommitments { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("title")]
        public virtual string? Title { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("totalJobOpenings")]
        public virtual Integer? TotalJobOpenings { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("validThrough")]
        public virtual object? ValidThrough { get; set; }

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
        [JsonPropertyName("workHours")]
        public virtual string? WorkHours { get; set; }

    }
}

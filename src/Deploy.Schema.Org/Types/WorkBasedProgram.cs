using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A program with both an educational and employment component. Typically based at a workplace and structured around work-based learning, with the aim of instilling competencies related to an occupation. WorkBasedProgram is used to distinguish programs such as apprenticeships from school, college or other classroom based educational programs.
    /// </summary>
    public partial class WorkBasedProgram : EducationalOccupationalProgram
    {
        public WorkBasedProgram()
        {
            Type = "WorkBasedProgram";
        }

    /// <summary>
    /// A program with both an educational and employment component. Typically based at a workplace and structured around work-based learning, with the aim of instilling competencies related to an occupation. WorkBasedProgram is used to distinguish programs such as apprenticeships from school, college or other classroom based educational programs.
    /// </summary>
        [JsonPropertyName("occupationalCategory")]
        public virtual object? OccupationalCategory { get; set; }

    /// <summary>
    /// A program with both an educational and employment component. Typically based at a workplace and structured around work-based learning, with the aim of instilling competencies related to an occupation. WorkBasedProgram is used to distinguish programs such as apprenticeships from school, college or other classroom based educational programs.
    /// </summary>
        [JsonPropertyName("trainingSalary")]
        public virtual MonetaryAmountDistribution? TrainingSalary { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
    public partial class EmployeeRole : OrganizationRole
    {
        public EmployeeRole()
        {
            Type = "EmployeeRole";
        }

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
        [JsonPropertyName("baseSalary")]
        public virtual object? BaseSalary { get; set; }

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// </summary>
        [JsonPropertyName("salaryCurrency")]
        public virtual string? SalaryCurrency { get; set; }

    }
}

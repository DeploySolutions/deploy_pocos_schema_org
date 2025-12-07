using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A school.
    /// </summary>
    public partial class School : EducationalOrganization
    {
        public School()
        {
            Type = "School";
        }

    }
}

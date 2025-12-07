using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// </summary>
    public partial class CollegeOrUniversity : EducationalOrganization
    {
        public CollegeOrUniversity()
        {
            Type = "CollegeOrUniversity";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A high school.
    /// </summary>
    public partial class HighSchool : EducationalOrganization
    {
        public HighSchool()
        {
            Type = "HighSchool";
        }

    }
}

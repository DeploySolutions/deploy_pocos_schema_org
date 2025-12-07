using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// </summary>
    public partial class MiddleSchool : EducationalOrganization
    {
        public MiddleSchool()
        {
            Type = "MiddleSchool";
        }

    }
}

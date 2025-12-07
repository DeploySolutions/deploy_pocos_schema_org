using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A preschool.
    /// </summary>
    public partial class Preschool : EducationalOrganization
    {
        public Preschool()
        {
            Type = "Preschool";
        }

    }
}

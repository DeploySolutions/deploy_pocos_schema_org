using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An elementary school.
    /// </summary>
    public partial class ElementarySchool : EducationalOrganization
    {
        public ElementarySchool()
        {
            Type = "ElementarySchool";
        }

    }
}

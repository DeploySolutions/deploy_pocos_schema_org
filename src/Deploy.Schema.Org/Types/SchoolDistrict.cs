using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A School District is an administrative area for the administration of schools.
    /// </summary>
    public partial class SchoolDistrict : AdministrativeArea
    {
        public SchoolDistrict()
        {
            Type = "SchoolDistrict";
        }

    }
}

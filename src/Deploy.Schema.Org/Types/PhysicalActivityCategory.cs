using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Categories of physical activity, organized by physiologic classification.
    /// </summary>
    public partial class PhysicalActivityCategory : Enumeration
    {
        public PhysicalActivityCategory()
        {
            Type = "PhysicalActivityCategory";
        }

    }
}

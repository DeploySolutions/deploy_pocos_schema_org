using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A moving company.
    /// </summary>
    public partial class MovingCompany : HomeAndConstructionBusiness
    {
        public MovingCompany()
        {
            Type = "MovingCompany";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A kind of lodging business that focuses on renting single properties for limited time.
    /// </summary>
    public partial class VacationRental : LodgingBusiness
    {
        public VacationRental()
        {
            Type = "VacationRental";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    public partial class AdultEntertainment : EntertainmentBusiness
    {
        public AdultEntertainment()
        {
            Type = "AdultEntertainment";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Animal shelter.
    /// </summary>
    public partial class AnimalShelter : LocalBusiness
    {
        public AnimalShelter()
        {
            Type = "AnimalShelter";
        }

    }
}

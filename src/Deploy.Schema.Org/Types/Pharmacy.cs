using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A pharmacy or drugstore.
    /// </summary>
    public partial class Pharmacy : MedicalBusiness
    {
        public Pharmacy()
        {
            Type = "Pharmacy";
        }

    }
}

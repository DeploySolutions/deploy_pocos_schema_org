using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerations related to health and the practice of medicine: A concept that is used to attribute a quality to another concept, as a qualifier, a collection of items or a listing of all of the elements of a set in medicine practice.
    /// </summary>
    public partial class MedicalEnumeration : Enumeration
    {
        public MedicalEnumeration()
        {
            Type = "MedicalEnumeration";
        }

    }
}

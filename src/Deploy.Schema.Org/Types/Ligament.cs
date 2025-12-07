using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A short band of tough, flexible, fibrous connective tissue that functions to connect multiple bones, cartilages, and structurally support joints.
    /// </summary>
    public partial class Ligament : AnatomicalStructure
    {
        public Ligament()
        {
            Type = "Ligament";
        }

    }
}

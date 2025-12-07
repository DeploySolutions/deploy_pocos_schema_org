using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    public partial class LifestyleModification : MedicalEntity
    {
        public LifestyleModification()
        {
            Type = "LifestyleModification";
        }

    }
}

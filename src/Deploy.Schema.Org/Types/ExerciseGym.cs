using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A gym.
    /// </summary>
    public partial class ExerciseGym : SportsActivityLocation
    {
        public ExerciseGym()
        {
            Type = "ExerciseGym";
        }

    }
}

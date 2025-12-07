using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    public partial class ExerciseAction : PlayAction
    {
        public ExerciseAction()
        {
            Type = "ExerciseAction";
        }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("course")]
        public virtual Place? Course { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("diet")]
        public virtual Diet? Diet { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("distance")]
        public virtual Distance? Distance { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("exerciseCourse")]
        public virtual Place? ExerciseCourse { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("exercisePlan")]
        public virtual ExercisePlan? ExercisePlan { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("exerciseRelatedDiet")]
        public virtual Diet? ExerciseRelatedDiet { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("exerciseType")]
        public virtual string? ExerciseType { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("fromLocation")]
        public virtual Place? FromLocation { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("opponent")]
        public virtual Person? Opponent { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("sportsActivityLocation")]
        public virtual SportsActivityLocation? SportsActivityLocation { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("sportsEvent")]
        public virtual SportsEvent? SportsEvent { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("sportsTeam")]
        public virtual SportsTeam? SportsTeam { get; set; }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
        [JsonPropertyName("toLocation")]
        public virtual Place? ToLocation { get; set; }

    }
}

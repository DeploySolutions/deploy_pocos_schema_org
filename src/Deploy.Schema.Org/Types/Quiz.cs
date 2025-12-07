using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Quiz: A test of knowledge, skills and abilities.
    /// </summary>
    public partial class Quiz : LearningResource
    {
        public Quiz()
        {
            Type = "Quiz";
        }

    }
}

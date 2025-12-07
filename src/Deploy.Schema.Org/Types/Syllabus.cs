using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A syllabus that describes the material covered in a course, often with several such sections per [[Course]] so that a distinct [[timeRequired]] can be provided for that section of the [[Course]].
    /// </summary>
    public partial class Syllabus : LearningResource
    {
        public Syllabus()
        {
            Type = "Syllabus";
        }

    }
}

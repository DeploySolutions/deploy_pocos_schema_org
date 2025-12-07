using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    public partial class ComicStory : CreativeWork
    {
        public ComicStory()
        {
            Type = "ComicStory";
        }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
        [JsonPropertyName("artist")]
        public virtual Person? Artist { get; set; }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
        [JsonPropertyName("colorist")]
        public virtual Person? Colorist { get; set; }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
        [JsonPropertyName("inker")]
        public virtual Person? Inker { get; set; }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
        [JsonPropertyName("letterer")]
        public virtual Person? Letterer { get; set; }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
        [JsonPropertyName("penciler")]
        public virtual Person? Penciler { get; set; }

    }
}

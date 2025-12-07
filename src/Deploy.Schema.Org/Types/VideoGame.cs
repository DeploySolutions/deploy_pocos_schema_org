using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    public partial class VideoGame : SoftwareApplication
    {
        public VideoGame()
        {
            Type = "VideoGame";
        }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("cheatCode")]
        public virtual CreativeWork? CheatCode { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("gameEdition")]
        public virtual string? GameEdition { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("gamePlatform")]
        public virtual object? GamePlatform { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("gameServer")]
        public virtual GameServer? GameServer { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("gameTip")]
        public virtual CreativeWork? GameTip { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("playMode")]
        public virtual GamePlayMode? PlayMode { get; set; }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}

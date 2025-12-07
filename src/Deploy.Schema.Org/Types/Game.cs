using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
    public partial class Game : CreativeWork
    {
        public Game()
        {
            Type = "Game";
        }

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
        [JsonPropertyName("characterAttribute")]
        public virtual Thing? CharacterAttribute { get; set; }

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
        [JsonPropertyName("gameItem")]
        public virtual Thing? GameItem { get; set; }

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
        [JsonPropertyName("gameLocation")]
        public virtual object? GameLocation { get; set; }

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
        [JsonPropertyName("numberOfPlayers")]
        public virtual QuantitativeValue? NumberOfPlayers { get; set; }

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
        [JsonPropertyName("quest")]
        public virtual Thing? Quest { get; set; }

    }
}

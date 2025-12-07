using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
    public partial class GameServer : Intangible
    {
        public GameServer()
        {
            Type = "GameServer";
        }

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
        [JsonPropertyName("game")]
        public virtual VideoGame? Game { get; set; }

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
        [JsonPropertyName("playersOnline")]
        public virtual Integer? PlayersOnline { get; set; }

    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// </summary>
        [JsonPropertyName("serverStatus")]
        public virtual GameServerStatus? ServerStatus { get; set; }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// </summary>
    public partial class GamePlayMode : Enumeration
    {
        public GamePlayMode()
        {
            Type = "GamePlayMode";
        }

    }
}

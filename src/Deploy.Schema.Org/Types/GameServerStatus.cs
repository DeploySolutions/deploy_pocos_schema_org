using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Status of a game server.
    /// </summary>
    public partial class GameServerStatus : StatusEnumeration
    {
        public GameServerStatus()
        {
            Type = "GameServerStatus";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// For a [[VideoGame]], such as used with a [[PlayGameAction]], an enumeration of the kind of game availability offered.
    /// </summary>
    public partial class GameAvailabilityEnumeration : Enumeration
    {
        public GameAvailabilityEnumeration()
        {
            Type = "GameAvailabilityEnumeration";
        }

    }
}

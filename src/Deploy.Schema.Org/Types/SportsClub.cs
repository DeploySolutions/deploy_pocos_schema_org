using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sports club.
    /// </summary>
    public partial class SportsClub : SportsActivityLocation
    {
        public SportsClub()
        {
            Type = "SportsClub";
        }

    }
}

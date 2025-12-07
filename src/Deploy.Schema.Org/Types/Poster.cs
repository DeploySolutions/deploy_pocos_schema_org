using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A large, usually printed placard, bill, or announcement, often illustrated, that is posted to advertise or publicize something.
    /// </summary>
    public partial class Poster : CreativeWork
    {
        public Poster()
        {
            Type = "Poster";
        }

    }
}

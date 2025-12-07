using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[LibrarySystem]] is a collaborative system amongst several libraries.
    /// </summary>
    public partial class LibrarySystem : Organization
    {
        public LibrarySystem()
        {
            Type = "LibrarySystem";
        }

    }
}

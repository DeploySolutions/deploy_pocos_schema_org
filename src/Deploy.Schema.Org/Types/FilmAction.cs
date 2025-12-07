using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// </summary>
    public partial class FilmAction : CreateAction
    {
        public FilmAction()
        {
            Type = "FilmAction";
        }

    }
}

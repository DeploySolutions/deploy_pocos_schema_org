using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An [[Article]] that an external entity has paid to place or to produce to its specifications. Includes [advertorials](https://en.wikipedia.org/wiki/Advertorial), sponsored content, native advertising and other paid content.
    /// </summary>
    public partial class AdvertiserContentArticle : Article
    {
        public AdvertiserContentArticle()
        {
            Type = "AdvertiserContentArticle";
        }

    }
}

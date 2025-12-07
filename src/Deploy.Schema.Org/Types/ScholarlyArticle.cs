using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A scholarly article.
    /// </summary>
    public partial class ScholarlyArticle : Article
    {
        public ScholarlyArticle()
        {
            Type = "ScholarlyArticle";
        }

    }
}

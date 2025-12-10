using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An [[OpinionNewsArticle]] is a [[NewsArticle]] that primarily expresses opinions rather than journalistic reporting of news and events. For example, a [[NewsArticle]] consisting of a column or [[Blog]]/[[BlogPosting]] entry in the Opinions section of a news publication.
    /// </summary>
    public partial class OpinionNewsArticle : NewsArticle
    {
        public OpinionNewsArticle()
        {
            Type = "OpinionNewsArticle";
        }

    }
}

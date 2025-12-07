using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[NewsArticle]] and [[CriticReview]] providing a professional critic's assessment of a service, product, performance, or artistic or literary work.
    /// </summary>
    public partial class ReviewNewsArticle : CriticReview
    {
        public ReviewNewsArticle()
        {
            Type = "ReviewNewsArticle";
        }

    }
}

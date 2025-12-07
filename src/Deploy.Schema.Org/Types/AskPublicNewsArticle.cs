using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[NewsArticle]] expressing an open call by a [[NewsMediaOrganization]] asking the public for input, insights, clarifications, anecdotes, documentation, etc., on an issue, for reporting purposes.
    /// </summary>
    public partial class AskPublicNewsArticle : NewsArticle
    {
        public AskPublicNewsArticle()
        {
            Type = "AskPublicNewsArticle";
        }

    }
}

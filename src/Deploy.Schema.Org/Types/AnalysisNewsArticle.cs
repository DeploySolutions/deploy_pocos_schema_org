using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An AnalysisNewsArticle is a [[NewsArticle]] that, while based on factual reporting, incorporates the expertise of the author/producer, offering interpretations and conclusions.
    /// </summary>
    public partial class AnalysisNewsArticle : NewsArticle
    {
        public AnalysisNewsArticle()
        {
            Type = "AnalysisNewsArticle";
        }

    }
}

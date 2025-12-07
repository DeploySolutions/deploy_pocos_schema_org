using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Search results page.
    /// </summary>
    public partial class SearchResultsPage : WebPage
    {
        public SearchResultsPage()
        {
            Type = "SearchResultsPage";
        }

    }
}

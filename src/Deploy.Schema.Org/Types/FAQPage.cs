using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[FAQPage]] is a [[WebPage]] presenting one or more "[Frequently asked questions](https://en.wikipedia.org/wiki/FAQ)" (see also [[QAPage]]).
    /// </summary>
    public partial class FAQPage : WebPage
    {
        public FAQPage()
        {
            Type = "FAQPage";
        }

    }
}

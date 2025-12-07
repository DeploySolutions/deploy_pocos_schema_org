using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).
    /// </summary>
    public partial class QAPage : WebPage
    {
        public QAPage()
        {
            Type = "QAPage";
        }

    }
}

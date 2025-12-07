using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Contact page.
    /// </summary>
    public partial class ContactPage : WebPage
    {
        public ContactPage()
        {
            Type = "ContactPage";
        }

    }
}

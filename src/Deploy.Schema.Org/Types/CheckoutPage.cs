using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Checkout page.
    /// </summary>
    public partial class CheckoutPage : WebPage
    {
        public CheckoutPage()
        {
            Type = "CheckoutPage";
        }

    }
}

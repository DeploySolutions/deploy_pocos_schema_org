using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Profile page.
    /// </summary>
    public partial class ProfilePage : WebPage
    {
        public ProfilePage()
        {
            Type = "ProfilePage";
        }

    }
}

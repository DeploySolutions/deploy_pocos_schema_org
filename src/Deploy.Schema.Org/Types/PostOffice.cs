using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A post office.
    /// </summary>
    public partial class PostOffice : GovernmentOffice
    {
        public PostOffice()
        {
            Type = "PostOffice";
        }

    }
}

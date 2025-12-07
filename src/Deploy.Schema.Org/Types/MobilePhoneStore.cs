using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    public partial class MobilePhoneStore : Store
    {
        public MobilePhoneStore()
        {
            Type = "MobilePhoneStore";
        }

    }
}

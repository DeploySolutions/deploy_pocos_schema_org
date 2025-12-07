using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An car dealership.
    /// </summary>
    public partial class AutoDealer : AutomotiveBusiness
    {
        public AutoDealer()
        {
            Type = "AutoDealer";
        }

    }
}

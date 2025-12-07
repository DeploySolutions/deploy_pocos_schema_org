using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Catholic church.
    /// </summary>
    public partial class CatholicChurch : Church
    {
        public CatholicChurch()
        {
            Type = "CatholicChurch";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    public partial class Code : CreativeWork
    {
        public Code()
        {
            Type = "Code";
        }

    }
}

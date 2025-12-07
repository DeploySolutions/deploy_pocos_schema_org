using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A table on a Web page.
    /// </summary>
    public partial class Table : WebPageElement
    {
        public Table()
        {
            Type = "Table";
        }

    }
}

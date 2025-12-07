using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    public partial class SpreadsheetDigitalDocument : DigitalDocument
    {
        public SpreadsheetDigitalDocument()
        {
            Type = "SpreadsheetDigitalDocument";
        }

    }
}

using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// </summary>
    public partial class Barcode : ImageObject
    {
        public Barcode()
        {
            Type = "Barcode";
        }

    }
}

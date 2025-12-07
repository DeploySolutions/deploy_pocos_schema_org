using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// </summary>
    public partial class DigitalDocumentPermissionType : Enumeration
    {
        public DigitalDocumentPermissionType()
        {
            Type = "DigitalDocumentPermissionType";
        }

    }
}

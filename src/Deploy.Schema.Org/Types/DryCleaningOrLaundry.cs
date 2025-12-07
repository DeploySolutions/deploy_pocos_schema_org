using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    public partial class DryCleaningOrLaundry : LocalBusiness
    {
        public DryCleaningOrLaundry()
        {
            Type = "DryCleaningOrLaundry";
        }

    }
}

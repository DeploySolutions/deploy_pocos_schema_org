using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// </summary>
    public partial class ReportedDoseSchedule : DoseSchedule
    {
        public ReportedDoseSchedule()
        {
            Type = "ReportedDoseSchedule";
        }

    }
}

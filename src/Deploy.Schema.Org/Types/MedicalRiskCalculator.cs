using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis. Note: use the url property of Thing to record any URLs for online calculators.
    /// </summary>
    public partial class MedicalRiskCalculator : MedicalRiskEstimator
    {
        public MedicalRiskCalculator()
        {
            Type = "MedicalRiskCalculator";
        }

    }
}

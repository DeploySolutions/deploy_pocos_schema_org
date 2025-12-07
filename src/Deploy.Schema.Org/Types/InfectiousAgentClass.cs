using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Classes of agents or pathogens that transmit infectious diseases. Enumerated type.
    /// </summary>
    public partial class InfectiousAgentClass : MedicalEnumeration
    {
        public InfectiousAgentClass()
        {
            Type = "InfectiousAgentClass";
        }

    }
}

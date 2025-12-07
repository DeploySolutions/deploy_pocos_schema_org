using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    public partial class RentAction : TradeAction
    {
        public RentAction()
        {
            Type = "RentAction";
        }

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
        [JsonPropertyName("landlord")]
        public virtual object? Landlord { get; set; }

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
        [JsonPropertyName("realEstateAgent")]
        public virtual RealEstateAgent? RealEstateAgent { get; set; }

    }
}

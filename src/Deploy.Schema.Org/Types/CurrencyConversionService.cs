using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// </summary>
    public partial class CurrencyConversionService : FinancialProduct
    {
        public CurrencyConversionService()
        {
            Type = "CurrencyConversionService";
        }

    }
}

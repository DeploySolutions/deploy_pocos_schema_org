using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A state or province of a country.
    /// </summary>
    public partial class State : AdministrativeArea
    {
        public State()
        {
            Type = "State";
        }

    }
}

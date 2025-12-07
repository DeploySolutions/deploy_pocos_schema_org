using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    public partial class PreOrderAction : TradeAction
    {
        public PreOrderAction()
        {
            Type = "PreOrderAction";
        }

    }
}

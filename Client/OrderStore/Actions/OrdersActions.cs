using System.Collections.Generic;
using FluxorSyncfusionGrid.Shared;

namespace FluxorSyncfusionGrid.Client.OrderStore.Actions
{
    public record SetErrorOrdersAction
    {
        public string ErrorMessage { get; set; }
    }

    public record SetOrdersAction
    {
        public List<Order> Orders { get; set; }
    }

    public record UpdateSingleOrderOrdersAction
    {
        public Order Order { get; set; }
    }

    public record DeleteSingleOrderOrdersAction
    {
        public Order Order { get; set; }
    }

    public record AsyncLoadOrdersAction 
    { }
}
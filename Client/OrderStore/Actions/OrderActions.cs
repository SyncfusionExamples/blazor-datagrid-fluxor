using System.Collections.Generic;
using FluxorSyncfusionGrid.Shared;

namespace FluxorSyncfusionGrid.Client.OrderStore.Actions
{
    public record SetErrorOrderAction
    {
        public string ErrorMessage { get; set; }
    }

    public record SetOrderAction
    {
        public Order Order { get; set; }
    }

    public record UpdateOrderAction
    {
        public Order Order { get; set; }
    }

    public record ResetOrderAction
    { }

    public record AsyncLoadOrderAction 
    { 
        public int Id { get; set; }
    }

    public record AsyncUpdateOrderAction
    {
        public Order Order { get; set; }
    }

    public record AsyncAddOrderAction
    {
        public Order Order { get; set; }
    }

    public record AsyncDeleteOrderAction
    {
        public Order Order { get; set; }
    }
}
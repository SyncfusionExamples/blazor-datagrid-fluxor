using System.Collections.Generic;
using Fluxor;
using FluxorSyncfusionGrid.Shared;

namespace FluxorSyncfusionGrid.Client.OrderStore.States
{
    public record OrdersState: OrderLoadableState
    {
        public List<Order> Orders { get; init; }
    }

    public class OrdersFeatureState : Feature<OrdersState>
    {
        public override string GetName()
        {
            return nameof(OrdersState);
        }

        protected override OrdersState GetInitialState()
        {
            return new OrdersState
            {
                IsLoading = false,
                HasError = false,
                ErrorMessage = "",
                Orders = new List<Order>()
            };
        }
    }
}
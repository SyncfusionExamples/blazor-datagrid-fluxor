using Fluxor;
using FluxorSyncfusionGrid.Shared;

namespace FluxorSyncfusionGrid.Client.OrderStore.States
{
    public record OrderState: OrderLoadableState
    {
        public Order Order { get; init; }
    }

    public class OrderFeatureState : Feature<OrderState>
    {
        public override string GetName()
        {
            return nameof(OrderState);
        }

        protected override OrderState GetInitialState()
        {
            return new OrderState
            {
                IsLoading = false,
                HasError = false,
                ErrorMessage = "",
                Order = new Order()
            };
        }
    }
}
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Fluxor;
using FluxorSyncfusionGrid.Shared;
using FluxorSyncfusionGrid.Client.OrderStore.Actions;
using FluxorSyncfusionGrid.Client.OrderStore.States;
using FluxorSyncfusionGrid.Client.Services;

namespace FluxorSyncfusionGrid.Client.OrderStore.Effects
{
    public class OrdersEffects
    {
        private readonly IState<OrdersState> State;
        private readonly OrderService OrderService;

        public OrdersEffects(IState<OrdersState> state, OrderService userService)
        {
            State = state;
            OrderService = userService;
        }

        [EffectMethod]
        public async Task AsyncLoadOrdersEffect(AsyncLoadOrdersAction action, IDispatcher dispatcher) 
        {
            // SIMULATE LONG ASYNC CALL
            await Task.Delay(1000);
            
            List<Order> users = await this.OrderService.GetOrders(); //Fetch the data
            dispatcher.Dispatch(new SetOrdersAction { Orders = users }); //dispatch the next action
        }
    }
}
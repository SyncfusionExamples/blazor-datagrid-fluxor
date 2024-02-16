using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Fluxor;
using FluxorSyncfusionGrid.Shared;
using FluxorSyncfusionGrid.Client.OrderStore.Actions;
using FluxorSyncfusionGrid.Client.OrderStore.States;
using FluxorSyncfusionGrid.Client.Services;

namespace FluxorSyncfusionGrid.Client.OrderStore.Effects
{
    public class OrderEffects
    {
        private readonly IState<OrderState> State;
        private readonly IState<OrdersState> OrdersState;
        private readonly OrderService OrderService;

        public OrderEffects(IState<OrderState> state, OrderService userService, IState<OrdersState> usersState)
        {
            State = state;
            OrderService = userService;
            OrdersState = usersState;
        }

 
        [EffectMethod]
        public async Task LoadOrderEffect(AsyncLoadOrderAction action, IDispatcher dispatcher) 
        {
            if (action.Id != 0)
            {
                // SIMULATE LONG ASYNC CALL
                await Task.Delay(1000);

                Order user = await this.OrderService.GetOrder(action.Id);
                dispatcher.Dispatch(new SetOrderAction { Order = user });
            }
            else 
            {
                dispatcher.Dispatch(new ResetOrderAction());
            }
        }


        [EffectMethod]
        public async Task AsyncUpdateOrderEffect(AsyncUpdateOrderAction action, IDispatcher dispatcher) 
        {
            // SIMULATE LONG ASYNC CALL
            await Task.Delay(1000);

            
            Order user = await this.OrderService.UpdateOrder(action.Order);

            
            dispatcher.Dispatch(new UpdateOrderAction { Order = user });

            
            await Task.Delay(1);
            dispatcher.Dispatch(new UpdateSingleOrderOrdersAction{ Order = user });
        }


        [EffectMethod]
        public async Task AsyncAddOrderEffect(AsyncAddOrderAction action, IDispatcher dispatcher) 
        {
            // SIMULATE LONG ASYNC CALL
            await Task.Delay(1000);

            
            Order user = await this.OrderService.AddOrder(action.Order);

         
            user.OrderID = OrdersState.Value.Orders.Max(p => p.OrderID) + 1;
            
           
            dispatcher.Dispatch(new UpdateOrderAction { Order = user });

            
            await Task.Delay(1);
            dispatcher.Dispatch(new UpdateSingleOrderOrdersAction { Order = user });
        }

        [EffectMethod]
        public async Task AsyncDeleteOrderEffect(AsyncDeleteOrderAction action, IDispatcher dispatcher) 
        {
            // SIMULATE LONG ASYNC CALL
            await Task.Delay(1000);

            
            bool isDeleted = await this.OrderService.DeleteOrder(action.Order);

            if (isDeleted)
            {                
                dispatcher.Dispatch(new ResetOrderAction());
                await Task.Delay(1);
                dispatcher.Dispatch(new DeleteSingleOrderOrdersAction{ Order = action.Order });
            }
        }
    }
}
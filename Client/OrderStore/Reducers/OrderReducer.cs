using Fluxor;
using FluxorSyncfusionGrid.Client.OrderStore.Actions;
using FluxorSyncfusionGrid.Client.OrderStore.States;
using FluxorSyncfusionGrid.Shared;

namespace FluxorSyncfusionGrid.Client.OrderStore.Reducers
{
    public static class OrderReducer
    {
        [ReducerMethod]
        public static OrderState OnSetOrder(OrderState state, SetOrderAction action)
        {
            return state with 
            {
                HasError = false,
                ErrorMessage = "",
                IsLoading = false,
                Order = action.Order
            };
        }

        [ReducerMethod]
        public static OrderState OnUpdateOrder(OrderState state, UpdateOrderAction action)
        {
            return state with 
            {
                HasError = false,
                ErrorMessage = "",
                IsLoading = false,
                Order = action.Order
            };
        }

        [ReducerMethod]
        public static OrderState OnSetErrorOrder(OrderState state, SetErrorOrderAction action)
        {
            return state with 
            {
                HasError = true,
                IsLoading = false,
                ErrorMessage = action.ErrorMessage
            };
        }

        [ReducerMethod]
        public static OrderState OnResetOrder(OrderState state, ResetOrderAction action)
        {
            return state with 
            {
                IsLoading = false,
                Order = new Order()
            };
        }

        [ReducerMethod]
        public static OrderState OnAsyncLoadOrder(OrderState state, AsyncLoadOrderAction action)
        {
            return state with 
            {
                IsLoading = true
            };
        }

        [ReducerMethod]
        public static OrderState OnAsyncUpdateOrder(OrderState state, AsyncUpdateOrderAction action)
        {
            return state with 
            {
                IsLoading = true
            };
        }

        [ReducerMethod]
        public static OrderState OnAsyncAddOrder(OrderState state, AsyncAddOrderAction action)
        {
            return state with 
            {
                IsLoading = true
            };
        }

        [ReducerMethod]
        public static OrderState OnAsyncDeleteOrder(OrderState state, AsyncDeleteOrderAction action)
        {
            return state with 
            {
                IsLoading = true
            };
        }

    }
}
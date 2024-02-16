using System.Collections.Generic;
using Fluxor;
using FluxorSyncfusionGrid.Client.OrderStore.Actions;
using FluxorSyncfusionGrid.Client.OrderStore.States;
using FluxorSyncfusionGrid.Shared;

namespace FluxorSyncfusionGrid.Client.OrderStore.Reducers
{
    public static class OrdersReducer
    {
        [ReducerMethod]
        public static OrdersState OnSetOrders(OrdersState state, SetOrdersAction action)
        {
            return state with 
            {
                HasError = false,
                ErrorMessage = "",
                IsLoading = false,
                Orders = action.Orders
            };
        }

        [ReducerMethod]
        public static OrdersState OnUpdateSingleOrderOrders(OrdersState state, UpdateSingleOrderOrdersAction action)
        {
            List<Order> newOrders = new List<Order>(state.Orders);
            Order user = newOrders.Find(p => p.OrderID == action.Order.OrderID);
            
            if (user != null)
            {
                user.OrderID = action.Order.OrderID;
                user.CustomerID = action.Order.CustomerID;
                user.Freight = action.Order.Freight;
                user.ShipCity = action.Order.ShipCity;
            }
            else 
            {
                newOrders.Insert(0, action.Order);
            }

            return state with 
            {
                Orders = newOrders
            };
        }

        [ReducerMethod]
        public static OrdersState OnSetErrorOrders(OrdersState state, SetErrorOrdersAction action)
        {
            return state with 
            {
                HasError = true,
                IsLoading = false,
                ErrorMessage = action.ErrorMessage
            };
        }

        [ReducerMethod]
        public static OrdersState OnAsyncLoadOrders(OrdersState state, AsyncLoadOrdersAction action)
        {
            return state with 
            {
                IsLoading = true
            };
        }

        [ReducerMethod]
        public static OrdersState OnDeleteSingleOrderOrders(OrdersState state, DeleteSingleOrderOrdersAction action)
        {
            List<Order> newOrders = new List<Order>(state.Orders);
            Order user = newOrders.Find(p => p.OrderID == action.Order.OrderID);

            if (user != null)
            {
                newOrders.Remove(user);
            }

            return state with
            {
                Orders = newOrders
            };
        }
    }
}
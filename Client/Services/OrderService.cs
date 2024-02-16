using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using FluxorSyncfusionGrid.Shared;
using Microsoft.Extensions.Configuration;
using System;

namespace FluxorSyncfusionGrid.Client.Services
{
    public class OrderService
    {
        private HttpClient http { get; set; }
        private IConfiguration configuration { get; set; }
        private string? Url { get; set; }

        public OrderService(HttpClient http, IConfiguration configuration)
        {
            this.http = http;
            this.configuration = configuration;
            this.Url = this.configuration["Url"];
        }

        public async Task<List<Order>> GetOrders(int limit = 10)
        {
            List<Order> items;            
            items = await this.http.GetFromJsonAsync<List<Order>>($"{this.Url}");            
            //items = await this.http.GetFromJsonAsync<List<Order>>($"{this.Url}posts?_limit={limit}");
            return items;
        }

        public async Task<Order> GetOrder(int userId)
        {
            Order user = await this.http.GetFromJsonAsync<Order>($"{this.Url}");
            //Order user = await this.http.GetFromJsonAsync<Order>($"{this.Url}posts/{userId}");
            return user;
        }

        public async Task<Order> AddOrder(Order user)
        {
            HttpResponseMessage response = await this.http.PostAsJsonAsync($"{this.Url}", user);
            Order savedOrder = await response.Content.ReadFromJsonAsync<Order>();
            return savedOrder;
        }

        public async Task<Order> UpdateOrder(Order user)
        {
            HttpResponseMessage response = await this.http.PutAsJsonAsync($"{this.Url}", user);
            Order savedOrder = await response.Content.ReadFromJsonAsync<Order>();            
            return savedOrder;
        }

        public async Task<bool> DeleteOrder(Order user)
        {
            //var response = await this.http.DeleteFromJsonAsync($"{this.Url}/{user.OrderID}");
            return true;
        }
    }
}

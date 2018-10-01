using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaWeb
{
    public class OrderHub : Hub
    {
        public void Create(List<OrderModel> Orders)
        {
            Clients.All.broadcastPerformance(Orders);
        }
    }

    public class OrderModel
    {
        [JsonProperty("OrderId")]
        public string OrderId { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("Quantity")]
        public double Quantity { get; set; }
    }
}
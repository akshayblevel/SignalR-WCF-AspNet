using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderService
{
    public class Order : IOrder
    {
        private readonly IHubProxy orderHub;

        public Order()
        {
            var connection = new HubConnection("http://localhost:5502/~/");
            orderHub = connection.CreateHubProxy("OrderHub");
            connection.Start().Wait();
        }
        public void Create(long OrderID)
        {
            List<OrderModel> models = new List<OrderModel>();
            OrderModel model = new OrderModel() { OrderId=OrderID.ToString(), ProductName="Laptop",Quantity=5 };
            models.Add(model);
            orderHub.Invoke("Create", models);
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

using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Client.Services
{
    public class ConsoleOrderService : IOrderService
    {
        public async Task PlaceOrderAsync(Basket basket)
        {
            Console.WriteLine($"Placing order for {basket.Customer.Name}");
            await Task.CompletedTask;
        }
    }
}

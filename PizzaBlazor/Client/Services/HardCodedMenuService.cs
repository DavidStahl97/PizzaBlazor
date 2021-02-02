using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Client.Services
{
    class HardCodedMenuService : IMenuService
    {
        public Task<Menu> GetMenuAsync()
        {
            return Task.FromResult(new Menu
            {
                Pizzas = new List<Pizza>
                {
                    new Pizza
                    {
                        Id = 1,
                        Name = "Pepperoni",
                        Price = 8.90M,
                        Spiciness = Spiciness.Spicy
                    },
                    new Pizza
                    {
                        Id = 2,
                        Name = "Margarita",
                        Price = 83.90M,
                        Spiciness = Spiciness.None
                    },
                    new Pizza
                    {
                        Id = 3,
                        Name = "Diabolo",
                        Price = 1.90M,
                        Spiciness = Spiciness.Hot
                    }
                }
            });
        }
    }
}

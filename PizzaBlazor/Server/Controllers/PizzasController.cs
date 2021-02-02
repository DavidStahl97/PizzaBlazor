using Microsoft.AspNetCore.Mvc;
using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Server.Controllers
{
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private static readonly List<Pizza> pizzas = new List<Pizza>
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
        };

        [HttpGet("pizzas")]
        public IQueryable<Pizza> GetPizzas()
            => pizzas.AsQueryable();
    }
}

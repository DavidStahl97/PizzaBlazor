using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public record Menu
    {
        public IEnumerable<Pizza> Pizzas { get; init; } = new List<Pizza>();

        public Pizza GetPizza(int id) => 
            Pizzas.SingleOrDefault(x => x.Id == id);
    }
}
